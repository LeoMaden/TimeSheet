using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetLibrary;
using TimeSheetLibrary.Models;

namespace FormUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GlobalConfig.InitialiseConnection();

            Application.Run(new SelectEmploymentForm());
            //Application.Run(new ReportForm("This Weeks Hours", GlobalConfig.Connection.GetReport_ThisWeeksHours(DayOfWeek.Sunday)));
            //Application.Run(new ReportForm("Sum of Hours", GlobalConfig.Connection.GetReport_SumOfHoursByEmployment()));
        }
    }
}
