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
    public partial class SelectEmploymentForm : Form
    {
        private List<Employment> EmploymentEntries;

        public SelectEmploymentForm()
        {
            InitializeComponent();
        }

        private void SelectEmploymentForm_Load(object sender, EventArgs e)
        {
            InitialiseForm();
        }

        private void InitialiseForm()
        {
            UpdateEmploymentOptionsComboBox();
        }

        private void UpdateEmploymentOptionsComboBox()
        {
            EmploymentEntries = null;
            EmploymentOptionsComboBox.DataSource = null;

            EmploymentEntries = GlobalConfig.Connection.GetEmployment_All();
            EmploymentEntries.Sort();
            EmploymentEntries.Reverse();
            EmploymentOptionsComboBox.DataSource = EmploymentEntries;
        }

        private void ChooseSelectedEmploymentButton_Click(object sender, EventArgs e)
        {
            if (ValidateSelection() == false)
            {
                MessageBox.Show("Invalid Selection");
                return;
            }

            Employment selected = (Employment) EmploymentOptionsComboBox.SelectedValue;

            this.Hide();

            var logHoursForm = new LogHoursForm(selected);
            logHoursForm.ShowDialog();

            this.Show();
        }

        private void AddNewEmploymentButton_Click(object sender, EventArgs e)
        {
            var newEmployment = new Employment();
            newEmployment = GlobalConfig.Connection.AddNewEmployment(newEmployment);

            this.Hide();

            var editEmploymentForm = new EditEmploymentForm(newEmployment);
            editEmploymentForm.ShowDialog();

            UpdateEmploymentOptionsComboBox();

            this.Show();
        }

        private void EditEmploymentButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            Employment selected = (Employment) EmploymentOptionsComboBox.SelectedItem;

            var editEmploymentForm = new EditEmploymentForm(selected);
            editEmploymentForm.ShowDialog();

            UpdateEmploymentOptionsComboBox();

            this.Show();
        }

        private bool ValidateSelection()
        {
            if (EmploymentOptionsComboBox.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }

        private void SelectEmploymentPayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
            

            if (ValidateSelection() == false)
            {
                MessageBox.Show("Invalid Selection");
                return;
            }

            var logPayForm = new LogPayForm((Employment)EmploymentOptionsComboBox.SelectedItem);

            this.Hide();
            logPayForm.ShowDialog();
            this.Show();
        }
    }
}
