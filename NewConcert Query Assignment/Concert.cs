using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConcert_Query_Assignment
{
    public class Concert
    {
        public int Id { get; set; }
        public bool ReducedVenue { get; set; }
        public DateTime Date { get; set; } 
        public DateTime StartDate = new DateTime(2024, 01, 01);
        public DateTime EndDate = new DateTime(2024, 12, 31);
        public DateTime DayOfWeek { get; set; }
        public string? Performer { get; set; }
        public int BeginsAt { get; set; }
        public int FullCapacitySales { get; set; }
    }
}
