using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Gender Gender { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}