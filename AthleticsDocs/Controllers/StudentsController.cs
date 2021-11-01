using System.Linq;
using AthleticsDocs.ViewModels;
using AthleticsDocs.ViewModels.Students;
using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

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
            var ranksList = _context.Ranks.Select(x => x);
            var citiesList = _context.Cities.Select(x => x).OrderBy(x => x.Name);
            var organizationsList = _context.Organizations.Select(x => x)
                .OrderBy(x => x.Name);
            var groupsList = _context.Groups.Select(x => x).OrderBy(x => x.Name);

            IndexViewModel index = new IndexViewModel()
            {
                Student = new Student(),
                Ranks = new SelectList(ranksList, nameof(Rank.Id), nameof(Rank.Name)),
                Cities = new SelectList(citiesList, nameof(City.Id), nameof(City.Name)),
                Organizations = new SelectList(organizationsList, nameof(Organization.Id),
                    nameof(Organization.Name)),
                Groups = new SelectList(groupsList, nameof(Group.Id), nameof(Group.Name))
            };

            return View(index);
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Students.Add(student);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            return View(student);
        }

    }
}
