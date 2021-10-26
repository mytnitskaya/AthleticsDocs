using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class LevelOfTraining
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Duration { get; set; }
    }
}