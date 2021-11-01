using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        [Required]
        public Person Person { get; set; }
        public Guid? RankId { get; set; }
        public Rank Rank { get; set; }
        public Guid? CityId { get; set; }
        public City City { get; set; }
        public Guid? OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public Guid? GroupId { get; set; }
        public Group Group { get; set; }
    }
}