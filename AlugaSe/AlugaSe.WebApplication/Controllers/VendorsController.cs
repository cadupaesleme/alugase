using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlugaSe.DomainModel.Entities;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using AlugaSe.DomainModel.Interfaces.Repositories;

namespace AlugaSe.WebApplication.Controllers
{
    public class VendorsController : Controller
    {
        private readonly IVendorRepository _repository;

        public VendorsController(IVendorRepository repository
            )
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(_repository.ReadAll());
        }

        //// GET: Vendors
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Vendors.ToListAsync());
        //}

        //// GET: Vendors/Details/5
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

        //// GET: Vendors/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Vendors/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Address,Identification,Rating,BirthDay,Gender,Id")] Vendor vendor)
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

        //// GET: Vendors/Edit/5
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

        //// POST: Vendors/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(Guid id, [Bind("Name,Address,Identification,Rating,BirthDay,Gender,Id")] Vendor vendor)
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

        //// GET: Vendors/Delete/5
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

        //// POST: Vendors/Delete/5
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
