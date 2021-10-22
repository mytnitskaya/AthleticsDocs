﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}