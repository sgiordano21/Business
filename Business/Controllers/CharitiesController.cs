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
    }
}