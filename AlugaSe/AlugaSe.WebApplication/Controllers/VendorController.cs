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
        public ActionResult Index()
        {
            return View(_vendorService.ReadAll());
        }

        // GET: Vendor
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Vendors.ToListAsync());
        //}

        //// GET: Vendor/Details/5
        //public async Task<IActionResult> Details(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var vendor = await _context.Vendors
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (vendor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(vendor);
        //}

        //// GET: Vendor/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Vendor/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Address,Identification,BirthDay,Gender,Id")] Vendor vendor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        vendor.Id = Guid.NewGuid();
        //        _context.Add(vendor);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(vendor);
        //}

        //// GET: Vendor/Edit/5
        //public async Task<IActionResult> Edit(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var vendor = await _context.Vendors.FindAsync(id);
        //    if (vendor == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(vendor);
        //}

        //// POST: Vendor/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Name,Address,Identification,BirthDay,Gender,Id")] Vendor vendor)
        //{
        //    if (id != vendor.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(vendor);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!VendorExists(vendor.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(vendor);
        //}

        //// GET: Vendor/Delete/5
        //public async Task<IActionResult> Delete(Guid? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var vendor = await _context.Vendors
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (vendor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(vendor);
        //}

        //// POST: Vendor/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(Guid id)
        //{
        //    var vendor = await _context.Vendors.FindAsync(id);
        //    _context.Vendors.Remove(vendor);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool VendorExists(Guid id)
        //{
        //    return _context.Vendors.Any(e => e.Id == id);
        //}
    }
}
