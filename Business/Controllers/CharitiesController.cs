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
    }
}