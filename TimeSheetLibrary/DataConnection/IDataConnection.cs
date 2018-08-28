using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetLibrary.Models;

namespace TimeSheetLibrary.DataConnection
{
    public interface IDataConnection
    {
        TimeSheetEntry AddNewTimeSheetEntry(TimeSheetEntry entry, Employment employment);

        Employment AddNewEmployment(Employment employment);

        void UpdateEmployment(Employment employment);

        List<Employment> GetEmployment_AllActive();

        List<Employment> GetEmployment_All();

        void DeleteEmployment(Employment employment);

        void DeleteTimeSheetEntry(TimeSheetEntry entry);

        IEnumerable<IDictionary<string, object>> GetReport_SumOfHoursByEmployment();

        List<TimeSheetEntry> GetHours_ThisWeek(Employment employment);

        double GetHours_NWeekAverage(int numberOfWeeks, DateTime endDate, Employment employment);
    }
}
