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

        //path: /Charities/
        public ActionResult Index()
        {
        List<Charity> model = _db.Charities.ToList();
        return View(model);
        }

        //path: /Charities/Details/{CharityId}
        public ActionResult Details(int id)
        {
        Charity thisCharity = _db.Charities.FirstOrDefault(c => c.CharityId == id);
        return View(thisCharity);
        }

        //path: /Charities/Create
        //to make this RESTful, we *could* give this GET method a route decorator to call it "new"
        public ActionResult Create()
        {
        return View();
        }

        //add new charity to database, then redirect to charities index (path: /Charities/)
        [HttpPost]
        public ActionResult Create(Charity youGetThePicture)
        {
        _db.Charities.Add(youGetThePicture);
        _db.SaveChanges();
        return RedirectToAction("Index");
        }

        
        
        public ActionResult Delete(int id)
        {
            var thisCharity = _db.Charities.FirstOrDefault(items => items.CharityId == id);

            return View(thisCharity);
        }

       [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var thisCharity = _db.Charities.FirstOrDefault(items => items.CharityId == id);
            _db.Charities.Remove(thisCharity);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}