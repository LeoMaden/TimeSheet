using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetLibrary.Models
{
    public class TimeSheetEntry
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public string Type { get; set; }

        public double HoursWorked { get; set; }

        public decimal HourlyRate { get; set; }
    }
}
