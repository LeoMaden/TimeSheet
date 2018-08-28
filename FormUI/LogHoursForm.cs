using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetLibrary;
using System.Text.RegularExpressions;
using System.Collections;
using TimeSheetLibrary.Models;
using TimeSheetLibrary.Misc;

namespace FormUI
{
    public partial class LogHoursForm : Form
    {
        private Employment Employment;

        private enum HoursViewOption { All, ThisWeek };

        private List<TimeSheetEntry> HoursListViewItems;

        private delegate double CalculateHoursWorked(double hoursWorked, HoursType hoursType, DateTime date, Employment employment);

        private string[] allowedHoursTypes = Enum.GetNames(typeof(HoursType));
        

        public LogHoursForm(Employment employment)
        {
            InitializeComponent();
            Employment = employment;
        }

        private void CalendarBox_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = CalendarBox.SelectionStart;
            SelectedDateLabel.Text = date.ToShortDateString();
        }

        private void LogHoursForm_Load(object sender, EventArgs e)
        {
            InitialiseForm();
            PopulateListViewBox();
        }

        private void InitialiseForm()
        {
            SelectedDateLabel.Text = DateTime.Now.ToShortDateString();
            EmploymentNameLabel.Text = Employment.CompanyName;
            HourlyRateTextBox.Text = Employment.DefaultHourlyRate.ToString();
            HoursListViewBox.ListViewItemSorter = new TimeSheetComparer();

            foreach (var item in Enum.GetValues(typeof(HoursViewOption)))
            {
                HoursViewOptionComboBox.Items.Add(item);
            }

            HoursViewOptionComboBox.SelectedIndex = 0;

            foreach (var type in allowedHoursTypes)
            {
                int i = HoursTypeComboBox.Items.Add(type);
                //HoursTypeComboBox.Items. = type.ToUpper();
            }

            HoursTypeComboBox.SelectedIndex = 0;
        }

        private void PopulateListViewBox()
        {
            var viewOption = (HoursViewOption)HoursViewOptionComboBox.SelectedItem;

            if (viewOption.GetType() != typeof(HoursViewOption))
            {
                MessageBox.Show("Invalid selection");
                HoursViewOptionComboBox.SelectedIndex = 0;
                return;
            }

            HoursListViewBox.Items.Clear();

            switch (viewOption)
            {
                case HoursViewOption.All:
                    HoursListViewItems = Employment.TimeSheetEntries;
                    break;
                case HoursViewOption.ThisWeek:
                    HoursListViewItems = GlobalConfig.Connection.GetHours_ThisWeek(Employment);
                    break;
                default:
                    throw new Exception("Something went wrong...");
            }

            for (int i = 0; i < HoursListViewItems.Count; i++)
            {
                TimeSheetEntry entry = HoursListViewItems[i];

                string[] cols =
                {
                    entry.Date.ToLongDateString(),
                    entry.Type.ToUpperInvariant(),
                    entry.HoursWorked.ToString(),
                    $"{entry.HourlyRate:C2}"
                };

                var listViewItem = new ListViewItem(cols);
                listViewItem.Tag = entry;

                HoursListViewBox.Items.Add(listViewItem);
            }

            HoursListViewBox.Sort();
        }

        private void SubmitHoursButton_Click(object sender, EventArgs e)
        {
            bool formValid = ValidateForm();

            if (formValid == true)
            {
                var newEntry = new TimeSheetEntry()
                {
                    Date = DateTime.Parse(SelectedDateLabel.Text),
                    Type = HoursTypeComboBox.SelectedItem.ToString().ToLower(),
                    HoursWorked = double.Parse(HoursWorkedEntryBox.Text),
                    HourlyRate = decimal.Parse(HourlyRateTextBox.Text)
                };

                GlobalConfig.Connection.AddNewTimeSheetEntry(newEntry, Employment);
                ClearInputs();
                PopulateListViewBox();
            }
            else
            {
                MessageBox.Show("Invalid data entered into form");
            }
        }

        private bool ValidateForm()
        {
            // No item has been selected from combo box.
            if (HoursTypeComboBox.SelectedIndex == -1)
            {
                return false;
            }

            // Date selected is in incorrect format.
            string date = SelectedDateLabel.Text;
            string datePattern = @"\d{2}/\d{2}/\d{4}";

            if (Regex.IsMatch(date, datePattern) == false)
            {
                throw new Exception("Date not in correct format");
            }

            // Hours worked does not contain a number.
            bool hoursValid = double.TryParse(HoursWorkedEntryBox.Text, out double hours);

            if (hoursValid == false)
            {
                return false;
            }

            // Hourly rate is not a number
            bool rateValid = decimal.TryParse(HourlyRateTextBox.Text, out decimal rate);

            if (rateValid == false)
            {
                return false;
            }

            // Check selected hours type is valid
            if (HoursTypeComboBox.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }
        

        private void ClearInputs()
        {
            HoursWorkedEntryBox.Text = "";
        }

        private void DeleteSelectedHoursButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete Entry", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            var selectedItems = HoursListViewBox.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                var selected = (TimeSheetEntry)item.Tag;

                Employment.TimeSheetEntries.Remove(selected);
                GlobalConfig.Connection.DeleteTimeSheetEntry(selected);
            }

            PopulateListViewBox();
        }

        private void HoursListViewBox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Prevent columns resizing.
            e.Cancel = true;
            e.NewWidth = HoursListViewBox.Columns[e.ColumnIndex].Width;
        }

        private void HoursViewOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListViewBox();
        }

        private void HoursListViewBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (HoursListViewBox.SelectedItems.Count == 0)
            //{
            //    return;
            //}

            //// Item is selected.

            //int firstSelectedIndex = HoursListViewBox.SelectedIndices[0];
            
            //var firstSelectedItem = (TimeSheetEntry)HoursListViewBox.Items[firstSelectedIndex].Tag;

            //SelectedDateLabel.Text = firstSelectedItem.Date.ToShortDateString();
            //HoursWorkedEntryBox.Text = firstSelectedItem.HoursWorked.ToString();
            //HourlyRateTextBox.Text = firstSelectedItem.HourlyRate.ToString();
            //HoursTypeComboBox.SelectedIndex = HoursTypeComboBox.Items.IndexOf(firstSelectedItem.Type);
            //CalendarBox.SelectionStart = firstSelectedItem.Date;
        }
    }
    
}



