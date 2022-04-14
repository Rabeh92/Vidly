using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        ApplicationDbContext _context;
        public CustomersController()
        {
            _context = ApplicationDbContext.Create();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ActionResult Index()
        {

            return View(_context.Customers.Include(c => c.MemberShipType).ToList());
        }


        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MemberShipType).FirstOrDefault(c => c.Id == id);
            if (customer != null)
                return View(customer);

            return HttpNotFound();

        }

        public ActionResult New()
        {
            var memberShipTypes = _context.MemberShipTypes.ToList();
            var newCustomerViewModel = new NewCustomerViewModel
            {
                MemberShipTypes = memberShipTypes
            };
            return View(newCustomerViewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer )
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }


    }
}