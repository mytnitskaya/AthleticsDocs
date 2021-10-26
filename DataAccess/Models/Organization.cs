using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Organization
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Person Director { get; set; }
    }
}