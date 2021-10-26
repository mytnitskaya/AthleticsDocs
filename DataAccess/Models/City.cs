using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class City
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
