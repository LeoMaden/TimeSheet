using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using TimeSheetLibrary.Models;

namespace TimeSheetLibrary.DataConnection
{
    public class SqlConnection : IDataConnection
    {
        public Employment AddNewEmployment(Employment employment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                var parameters = new DynamicParameters();

                parameters.Add("@CompanyName", employment.CompanyName);

                if (employment.StartDate == DateTime.MinValue)
                {
                    parameters.Add("@StartDate", DateTime.Today);
                }
                else
                {
                    parameters.Add("@StartDate", employment.StartDate);
                }

                parameters.Add("@DefaultHourlyRate", employment.DefaultHourlyRate);

                if (employment.EndDate != DateTime.MinValue)
                {
                    parameters.Add("@EndDate", employment.EndDate);
                }

                parameters.Add("@WeekBegin", employment.WeekBegin.ToString());


                parameters.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spEmployment_AddNewEmployment", parameters, commandType: CommandType.StoredProcedure);

                employment.ID = parameters.Get<int>("@ID");
            }

            return employment;
        }

        public TimeSheetEntry AddNewTimeSheetEntry(TimeSheetEntry entry, Employment employment)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Date", entry.Date);
                parameters.Add("@Type", entry.Type);
                parameters.Add("@HoursWorked", entry.HoursWorked);
                parameters.Add("@HourlyRate", entry.HourlyRate);
                parameters.Add("@EmploymentID", employment.ID);
                parameters.Add("@ID", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spHours_AddNewTimeSheetEntry", parameters, commandType: CommandType.StoredProcedure);

                entry.ID = parameters.Get<int>("@ID");
            }

            employment.TimeSheetEntries.Add(entry);

            return entry;
        }

        public void DeleteEmployment(Employment employment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", employment.ID);

                connection.Execute("dbo.spEmployment_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteTimeSheetEntry(TimeSheetEntry entry)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", entry.ID);

                connection.Execute("dbo.spHours_Delete", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<Employment> GetEmployment_All()
        {
            var entries = new List<Employment>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                IEnumerable<dynamic> employments = connection.Query("dbo.spEmployment_GetAll", commandType: CommandType.StoredProcedure).ToList();

                foreach (var employment in employments)
                {
                    int employmentID = employment.ID;

                    var p = new DynamicParameters();
                    p.Add("@EmpID", employmentID);

                    List<TimeSheetEntry> timeSheetEntries = connection.Query<TimeSheetEntry>("dbo.spHours_GetByEmploymentID", p, commandType: CommandType.StoredProcedure).ToList();

                    var emp = new Employment
                    {
                        ID = employmentID,
                        CompanyName = employment.CompanyName,
                        StartDate = employment.StartDate,
                        DefaultHourlyRate = employment.DefaultHourlyRate,
                        TimeSheetEntries = timeSheetEntries,
                        WeekBegin = Enum.Parse(typeof(DayOfWeek), employment.WeekBegin)
                    };

                    if (employment.EndDate != null)
                    {
                        emp.EndDate = employment.EndDate;
                    }

                    entries.Add(emp);
                }
            }

            return entries;
        }

        public List<Employment> GetEmployment_AllActive()
        {
            var entries = new List<Employment>();

            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                IEnumerable<dynamic> employments = connection.Query("dbo.spEmployment_GetAllActive", commandType: CommandType.StoredProcedure).ToList();

                foreach (var employment in employments)
                {
                    int employmentID = employment.ID;

                    var p = new DynamicParameters();
                    p.Add("@EmpID", employmentID);

                    List<TimeSheetEntry> timeSheetEntries = connection.Query<TimeSheetEntry>("dbo.spHours_GetByEmploymentID", p, commandType: CommandType.StoredProcedure).ToList();

                    entries.Add(new Employment
                    {
                        ID = employmentID,
                        CompanyName = employment.CompanyName,
                        StartDate = employment.StartDate,
                        DefaultHourlyRate = employment.DefaultHourlyRate,
                        TimeSheetEntries = timeSheetEntries
                    });
                }
            }

            return entries;
        }

        public IEnumerable<IDictionary<string, object>> GetReport_SumOfHoursByEmployment()
        {
            IEnumerable<IDictionary<string, object>> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                output = (IEnumerable<IDictionary<string,object>>)connection.Query("dbo.spHours_SumOfHoursByEmployment", commandType: CommandType.StoredProcedure);
            }

            return output;
        }

        public List<TimeSheetEntry> GetHours_ThisWeek(Employment employment)
        {
            int offset = Math.Abs(DateTime.Today.DayOfWeek - employment.WeekBegin);
            DateTime startDate = DateTime.Today.AddDays(-offset);
            DateTime endDate = startDate.AddDays(6);

            List<TimeSheetEntry> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Start", startDate);
                parameters.Add("@End", endDate);
                parameters.Add("@EmploymentID", employment.ID);

                output = connection.Query<TimeSheetEntry>("dbo.spHours_GetBetweenDateRange", parameters, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public void UpdateEmployment(Employment employment)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ID", employment.ID, dbType: DbType.Int32);
                parameters.Add("@CompanyName", employment.CompanyName);
                parameters.Add("@StartDate", employment.StartDate);
                parameters.Add("@DefaultHourlyRate", employment.DefaultHourlyRate);
                parameters.Add("@WeekBegin", employment.WeekBegin.ToString());

                if (employment.EndDate != DateTime.MinValue)
                {
                    parameters.Add("@EndDate", employment.EndDate);
                }

                connection.Execute("dbo.spEmployment_Update", parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public double GetHours_NWeekAverage(int numberOfWeeks, DateTime endDate, Employment employment)
        {
            double average;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.GetCnnString("WorkTimeSheet")))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@NumberOfWeeks", numberOfWeeks);
                parameters.Add("@EndDate", endDate);
                parameters.Add("@EmploymentID", employment.ID);

                average = connection.Query<double>("dbo.spHours_NWeekHoursAverage", parameters, commandType: CommandType.StoredProcedure).ToList().First();
            }

            return average;
        }
    }
}
