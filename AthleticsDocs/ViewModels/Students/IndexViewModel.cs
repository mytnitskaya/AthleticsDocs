using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccess.Models;

namespace AthleticsDocs.ViewModels.Students
{
    public class IndexViewModel
    {
        public Student Student { get; set; }
        public SelectList Ranks { get; set; }
        public SelectList Cities { get; set; }
        public SelectList Organizations { get; set; }
        public SelectList Groups { get; set; }
    }
}