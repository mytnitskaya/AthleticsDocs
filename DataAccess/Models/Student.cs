using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        [Required]
        public Person Person { get; set; }
        public Rank Rank { get; set; }
        public City City { get; set; }
        public Organization Organization { get; set; }

        public Coach Coach { get; set; }

    }
}