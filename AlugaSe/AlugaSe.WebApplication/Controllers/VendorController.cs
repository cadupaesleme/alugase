using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlugaSe.DomainModel.Entities;
using AlugaSe.DomainService;
using AlugaSe.DomainService.Interfaces;
using AlugaSe.DomainModel.ValueObjects;

namespace AlugaSe.WebApplication.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorService _vendorService;

        public VendorController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        //// GET: Vendor
        public IActionResult Index()
        {
            return View(_vendorService.ReadAll());
        }

        // GET: Vendor/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = _vendorService.Read(id.Value);

            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // GET: Vendor/Create
        public IActionResult Create()
        {
            ViewBag.Genders = new SelectList(Gender.ListAll(), "Description", "Description");
            ViewBag.IdentificationTypes = new SelectList(Identification.ListTypes());

            return View();
        }

        // POST: Vendor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Address,BirthDay,Id")] Vendor vendor, string gender, string identificationType, string identificationNumber)
        {
            if (ModelState.IsValid)
            {
                vendor.Identification = Identification.NewIdentification(identificationType, identificationNumber);
                vendor.Gender = Gender.NewGender(gender);

                vendor.Id = Guid.NewGuid();

                _vendorService.Create(vendor);
                _vendorService.Complete();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Genders = new SelectList(Gender.ListAll(), "Description", "Description");
            ViewBag.IdentificationTypes = new SelectList(Identification.ListTypes());

            return View(vendor);
        }

        // GET: Vendor/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = _vendorService.Read(id.Value);
            if (vendor == null)
            {
                return NotFound();
            }

            ViewBag.Genders = new SelectList(Gender.ListAll(), "Description", "Description", vendor.Gender.Description);
            ViewBag.IdentificationTypes = new SelectList(Identification.ListTypes(), vendor.Identification.Type);


            return View(vendor);
        }

        // POST: Vendor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Name,Address,BirthDay,Id")] Vendor vendor, string gender, string identificationType, string identificationNumber)
        {
            if (ModelState.IsValid)
            {
                vendor.Identification = Identification.NewIdentification(identificationType, identificationNumber);
                vendor.Gender = Gender.NewGender(gender);

                _vendorService.Update(vendor);
                _vendorService.Complete();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Genders = new SelectList(Gender.ListAll(), "Description", "Description");
            ViewBag.IdentificationTypes = new SelectList(Identification.ListTypes());

            return View(vendor);
        }

        // GET: Vendor/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendor = _vendorService.Read(id.Value);

            if (vendor == null)
            {
                return NotFound();
            }

            return View(vendor);
        }

        // POST: Vendor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _vendorService.Delete(id);
            _vendorService.Complete();

            return RedirectToAction(nameof(Index));
        }

        //private bool VendorExists(Guid id)
        //{
        //    return _context.Vendors.Any(e => e.Id == id);
        //}
    }
}
