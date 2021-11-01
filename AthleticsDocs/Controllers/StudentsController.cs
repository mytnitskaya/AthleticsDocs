﻿using System.Linq;
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
            RanksDropDownList();
            CitiesDropDownList();
            OrganizationsDropDownList();
            GroupsDropDownList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //_context.People.Add(student.Person);
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
            RanksDropDownList(student.RankId);
            CitiesDropDownList(student.CityId);
            OrganizationsDropDownList(student.OrganizationId);
            GroupsDropDownList(student.GroupId);
            return View(student);
        }

        private void RanksDropDownList(object selectedRank = null)
        {
            //var ranksList = _context.Ranks.Select(x => x).OrderBy(x => x.Name);
            var ranksList = _context.Ranks.Select(x => x);
            ViewBag.RanksList = new SelectList(ranksList, nameof(Rank.Id), nameof(Rank.Name), selectedRank);
        }

        private void CitiesDropDownList(object selectedCity = null)
        {
            var citiesList = _context.Cities.Select(x => x).OrderBy(x => x.Name);
            ViewBag.CitiesList = new SelectList(citiesList, nameof(City.Id), nameof(City.Name), selectedCity);
        }
        private void OrganizationsDropDownList(object selectedOrganization = null)
        {
            var organizationsList = _context.Organizations.Select(x => x).OrderBy(x => x.Name);
            ViewBag.OrganizationsList = new SelectList(organizationsList, nameof(Organization.Id), 
                nameof(Organization.Name), selectedOrganization);
        }
        private void GroupsDropDownList(object selectedGroup = null)
        {
            var groupsList = _context.Groups.Select(x => x).OrderBy(x => x.Name);
            ViewBag.GroupsList = new SelectList(groupsList, nameof(Group.Id), nameof(Group.Name), selectedGroup);
        }
    }
}
