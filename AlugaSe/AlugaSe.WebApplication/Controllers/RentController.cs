using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlugaSe.DomainModel.Entities;
using AlugaSe.Infrastructure.DataAccess.Contexts;
using AlugaSe.DomainService.Interfaces;

namespace AlugaSe.WebApplication.Controllers
{
    public class RentController : Controller
    {
        private readonly IRentService _rentService;
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public RentController(IRentService rentService, ICustomerService customerService, IProductService productService)
        {
            _rentService = rentService;
            _customerService = customerService;
            _productService = productService;
        }

        // GET: Rent
        public IActionResult Index()
        {
            return View(_rentService.ReadAll().OrderByDescending(r => r.Date));
        }

        // GET: Rent/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = _rentService.Read(id.Value);
            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }

        // GET: Rent/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_customerService.ReadAll(), "Id", "Name");
            ViewData["Product"] = _productService.ReadAll();
            return View();
        }

        // POST: Rent/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create([FromBody]Rent rent)
        {
            var result = "";
            try
            {
                if (ModelState.IsValid)
                {
                    rent.Id = Guid.NewGuid();
                    rent.Date = DateTime.Now;

                    _rentService.CreateWithItems(rent);

                    result = "Success";

                }
            }
            catch (Exception ex)
            {
                result = "Error: The rent has not saved - " + ex.Message;
            }

            ViewData["CustomerId"] = new SelectList(_customerService.ReadAll(), "Id", "Name", rent.CustomerId);
            ViewData["Product"] = _productService.ReadAll();

            return Json(result);
        }

        // GET: Rent/Delete/5
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = _rentService.Read(id.Value);

            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }

        // POST: Rent/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _rentService.Delete(id);
            _rentService.Complete();

            return RedirectToAction(nameof(Index));
        }
    }
}
