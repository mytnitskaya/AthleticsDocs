using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public LevelOfTraining Level { get; set; }
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public Coach Coach { get; set; }
    }
}