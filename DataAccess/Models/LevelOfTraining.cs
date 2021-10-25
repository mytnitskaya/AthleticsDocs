using System;

namespace DataAccess.Models
{
    public class LevelOfTraining
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
    }
}