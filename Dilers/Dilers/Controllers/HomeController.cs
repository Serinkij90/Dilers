using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dilers.Models;
using Dilers.Data;

namespace Dilers.Controllers
{
    public class HomeController : Controller
    {
        private DilerContext _context;

        public HomeController(DilerContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var dilers = _context.Dilers.ToList();
            return View(dilers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Diler model)
        {
            _context.Dilers.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var diler = _context.Dilers.FirstOrDefault(x => x.Id == id);
            if (diler == null) return NotFound();
            return View(diler);
        }
        [HttpPost]
        public IActionResult Edit(Diler model)
        {
            _context.Dilers.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var diler = _context.Dilers.FirstOrDefault(x => x.Id == id);
            if (diler == null) return NotFound();
            return View(diler);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var diler = _context.Dilers.FirstOrDefault(x => x.Id == id);
            if (diler == null) return NotFound();
            _context.Dilers.Remove(diler);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
