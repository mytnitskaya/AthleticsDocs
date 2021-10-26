using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DataAccess.Models
{
    public class Coach
    {
        public Guid Id { get; set; }
        [Required]
        public Person Person { get; set; }
        public City City { get; set; }
        public Organization Organization { get; set; }
        public Coach Friend { get; set; }
        public ICollection<Group> Groups { get; set; } = new List<Group>();
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}