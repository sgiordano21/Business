using Microsoft.AspNetCore.Mvc;
using Business.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Business.Controllers
{
    public class BoardMembersController : Controller
    {
        private readonly BusinessContext _db;

        public BoardMembersController(BusinessContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<BoardMember> model = _db.BoardMembers.Include(boardmembers => boardmembers.Charity).ToList();
            return View(model);
        }

        // public ActionResult Create(int CharityId)
        // {
        //     ViewBag.CharityId = CharityId;
        //     return View();
        // }

        // [HttpPost()]
        // public ActionResult Create(BoardMember boardmember)
        // {
        //     _db.BoardMembers.Add(boardmember);
        //     _db.SaveChanges();
        //     Console.WriteLine("BOARDMEMBER.CHARITYID: " + boardmember.CharityId);
            
        //     return RedirectToAction("Details", boardmember);
        // }


        // [HttpGet]
        public ActionResult Create()
        {
            ViewBag.CharityId = new SelectList(_db.Charities, "CharityId", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(BoardMember boardMember)
        {
            _db.BoardMembers.Add(boardMember);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        
        
        
        
        
        
        
        
        
        
        
        public ActionResult Details(int CharityId)
        {
            BoardMember thisMember = _db.BoardMembers.FirstOrDefault(d => d.BoardMemberId == CharityId);
            return View(thisMember);
        }
    }
}