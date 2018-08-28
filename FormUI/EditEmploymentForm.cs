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
using TimeSheetLibrary.Models;

namespace FormUI
{
    public partial class EditEmploymentForm : Form
    {
        private Employment Employment;

        private event EventHandler<EventArgs> ElementsUpdated;


        public EditEmploymentForm(Employment employment)
        {
            InitializeComponent();
            Employment = employment;
            ElementsUpdated += EditEmploymentForm_ElementsUpdated;
        }

        private void EditEmploymentForm_ElementsUpdated(object sender, EventArgs e)
        {
            StatusLabel.Text = "";
        }

        private void EditEmploymentForm_Load(object sender, EventArgs e)
        {
            InitialiseForm();
        }

        private void InitialiseForm()
        {
            CompanyNameEntryBox.Text = Employment.CompanyName;

            // Start date setup.
            if (Employment.StartDate == DateTime.MinValue)
            {
                StartDatePicker.Value = DateTime.Today;
            }
            else
            {
                StartDatePicker.Value = Employment.StartDate;
            }

            // End date setup.
            if (Employment.EndDate == DateTime.MinValue)
            {
                EmploymentEndedCheckBox.Checked = false;
                EndDateLabel.Enabled = false;
                EndDatePicker.Enabled = false;
                EndDatePicker.Value = EndDatePicker.MinDate;
            }
            else
            {
                EmploymentEndedCheckBox.Checked = true;
                EndDateLabel.Enabled = true;
                EndDatePicker.Enabled = true;
                EndDatePicker.Value = Employment.EndDate;
            }

            if (Employment.DefaultHourlyRate == 0M)
            {
                HourlyRateEntryBox.Text = "";
            }
            else
            {
                HourlyRateEntryBox.Text = Employment.DefaultHourlyRate.ToString();
            }

            // Week begins combo box setup.
            WeekBeginsComboBox.DataSource = Enum.GetValues(typeof(DayOfWeek));
            WeekBeginsComboBox.Update();
            WeekBeginsComboBox.SelectedItem = Employment.WeekBegin;

            StatusLabel.Text = "Saved";
        }

        private void EmploymentEndedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ElementsUpdated.Invoke(sender, e);

            bool state = EmploymentEndedCheckBox.Checked;

            if (state == true)
            {
                EndDatePicker.Value = DateTime.Today;
            }
            else if (state == false)
            {
                EndDatePicker.Value = EndDatePicker.MinDate;
            }

            EndDateLabel.Enabled = state;
            EndDatePicker.Enabled = state;
        }

        private bool ValidateForm()
        {
            // Name is not blank.
            if (CompanyNameEntryBox.Text == "")
            {
                return false;
            }

            // Hourly rate is a number.
            bool rateValid = decimal.TryParse(HourlyRateEntryBox.Text, out decimal rate);

            if (rateValid == false)
            {
                return false;
            }

            // Day of week is selected.
            if (WeekBeginsComboBox.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }

        private void SaveEmploymentButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == false)
            {
                MessageBox.Show("Invalid information entered");
                return;
            }

            Employment.CompanyName = CompanyNameEntryBox.Text;
            Employment.StartDate = StartDatePicker.Value;

            if (EmploymentEndedCheckBox.Checked == true)
            {
                Employment.EndDate = EndDatePicker.Value;
            }
            else
            {
                Employment.EndDate = DateTime.MinValue;
            }

            Employment.DefaultHourlyRate = decimal.Parse(HourlyRateEntryBox.Text);

            Employment.WeekBegin = (DayOfWeek)WeekBeginsComboBox.SelectedItem;
            
            GlobalConfig.Connection.UpdateEmployment(Employment);

            StatusLabel.Text = "Saved";
        }

        private void DeleteEmploymentButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete Employment", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                return;
            }

            GlobalConfig.Connection.DeleteEmployment(Employment);
            this.Close();
        }

        private void CompanyNameEntryBox_TextChanged(object sender, EventArgs e)
        {
            ElementsUpdated.Invoke(sender, e);
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ElementsUpdated.Invoke(sender, e);
        }

        private void HourlyRateEntryBox_TextChanged(object sender, EventArgs e)
        {
            ElementsUpdated.Invoke(sender, e);
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ElementsUpdated.Invoke(sender, e);
        }

        private void WeekBeginsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElementsUpdated.Invoke(sender, e);
        }
    }
}
