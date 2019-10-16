using Microsoft.AspNetCore.Mvc;
using Business.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Business.Controllers
{
    public class CharitiesController : Controller
    {
        private readonly BusinessContext _db;

        public CharitiesController(BusinessContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
        List<Charity> model = _db.Charities.ToList();
        return View(model);
        }

        public ActionResult Details(int id)
        {
        Charity thisCharity = _db.Charities.FirstOrDefault(c => c.CharityId == id);
        return View(thisCharity);
        }

        [HttpPost, ActionName("Details")]
        public ActionResult Destroy(int id)
        {
            var toBeDeleted = _db.Charities.FirstOrDefault(charities => charities.CharityId == id);
            _db.Charities.Remove(toBeDeleted);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
        return View();
        }

        [HttpPost]
        public ActionResult Create(Charity youGetThePicture)
        {
        _db.Charities.Add(youGetThePicture);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }
    }
}