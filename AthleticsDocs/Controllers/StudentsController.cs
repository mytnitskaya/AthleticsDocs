using System.Linq;
using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AthleticsDocs.Controllers
{
    public class StudentsController : Controller
    {
        private AthleticsDocsContext _context;

        public StudentsController(AthleticsDocsContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students
                .Include(x => x.Person)
                .Include(x => x.Rank)
                .Include(x => x.City)
                .Include(x => x.Organization)
                .Include(x => x.Group);
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create([Bind(include: Person)]Student student)
        //{
        //    return View();
        //}
    }
}
