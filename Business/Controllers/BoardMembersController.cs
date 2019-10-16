using Microsoft.AspNetCore.Mvc;
using Business.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Business.Controllers
{
    public class BoardMembersController : Controller
    {
        private readonly BusinessContext _db;

        public BoardMembersController(BusinessContext db)
        {
            _db = db;
        }

    }
}