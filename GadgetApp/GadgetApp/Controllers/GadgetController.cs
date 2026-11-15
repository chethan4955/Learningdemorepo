using Microsoft.AspNetCore.Mvc;
using GadgetApp.Data;
using GadgetApp.Models;

namespace GadgetApp.Controllers
{
    public class GadgetController : Controller
    {
        private readonly ApplicationDbContextDb _context;

        public GadgetController(ApplicationDbContextDb context)
        {
            _context = context;
        }
        public IActionResult Index() {
            var gadgets =_context.gadgets.ToList();
            return View(gadgets);
                }
        [HttpGet]
        public IActionResult Create()
        {
            var categories = _context.categories.ToList();

            ViewBag.Categories = categories;

            return View();
        }
        [HttpPost]
        public IActionResult Create(Gadget gadget)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = _context.categories.ToList();

                return View(gadget);
            }

            _context.gadgets.Add(gadget);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var gadget = _context.gadgets.Find(id);
        //    if (gadget == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(gadget);
        //}
        //[HttpGet]
        public IActionResult Edit(int id)
        {
            var gadget = _context.gadgets.Find(id);

            if (gadget == null)
            {
                return NotFound();
            }

            return View(gadget);
        }

      
        [HttpPost]
        public IActionResult Edit(Gadget gadget)
        {
            if (!ModelState.IsValid)
            {
                return View(gadget);
            }

            _context.gadgets.Update(gadget);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
