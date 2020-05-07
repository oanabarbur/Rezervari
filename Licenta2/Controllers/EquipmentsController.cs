using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Licenta2.Migrations;
using Licenta2.Models;
using Licenta2.ViewModels;

namespace Licenta2.Controllers
{
    public class EquipmentsController : Controller
    {
        private ApplicationDbContext _context;
        public EquipmentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var equipments = _context.Equipment.Include(m => m.Category).ToList();
            return View(equipments);
        }

        public ViewResult New()
        {
            var category = _context.Category.ToList();

            var viewModel = new EquipmentFormViewModel
            {
                Category = category
            };
            return View("EquipmentForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var equipment = _context.Equipment.SingleOrDefault(c => c.Id == id);

            if (equipment == null)
                return HttpNotFound();

            var viewModel = new EquipmentFormViewModel
            {
                Equipment = equipment,
                Category = _context.Category.ToList()
            };
            return View("EquipmentForm", viewModel);
        }
        public ActionResult Details(int id)
        {
            var equipment = _context.Equipment.Include(m => m.Category).SingleOrDefault(m => m.Id == id);
            if (equipment == null)
                return HttpNotFound();
            return View(equipment);
        }
        // GET: Equipments
        public ActionResult Random()
        {
            var equipment = new Equipment() { Name = "schiuri" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomEquipmentViewModel
            {
                Equipment = equipment,
                Customers = customers
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Save (Equipment equipment)
        {
            if(equipment.Id == 0)
            {
                equipment.DateAdded = DateTime.Now;
                _context.Equipment.Add(equipment);
            }
            else
            {
                var equipmentInDb = _context.Equipment.Single(mbox => mbox.Id == equipment.Id);

                equipmentInDb.Name = equipment.Name;
                equipmentInDb.CategoryId = equipment.CategoryId;
                equipmentInDb.NumberInStock = equipment.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Equipments");
        }
 
    }
}