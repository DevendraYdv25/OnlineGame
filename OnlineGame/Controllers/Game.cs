using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineGame.Models;//project name
namespace OnlineGame.Controllers
{
    public class Game : Controller
    {
        private readonly AppDataContext _adt;
        public Game(AppDataContext adt)
        {
            _adt = adt;
        }

        public IActionResult Index()
        {
            //Add  the table name Exam here
            var result = _adt.GameTBL.ToList();
            return View(result);
        }
    }
}
