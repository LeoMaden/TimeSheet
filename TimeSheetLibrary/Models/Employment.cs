using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetLibrary.Models
{
    public class Employment : IComparable<Employment>
    {
        public int ID { get; set; }

        public string CompanyName { get; set; } = "";

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal DefaultHourlyRate { get; set; }

        public List<TimeSheetEntry> TimeSheetEntries { get; set; } = new List<TimeSheetEntry>();

        public List<PaymentEntry> PaymentEntries { get; set; } = new List<PaymentEntry>();

        public DayOfWeek WeekBegin { get; set; } = DayOfWeek.Sunday;


        public int CompareTo(Employment other)
        {
            return StartDate.CompareTo(other.StartDate);
        }

        public override string ToString()
        {
            string output;

            if (EndDate == DateTime.MinValue)
            {
                output = $"{ CompanyName } ({ StartDate.ToShortDateString() })";
            }
            else
            {
                output = $"{ CompanyName } (END: { EndDate.ToShortDateString() })";
            }

            return output;
        }
    }
}
