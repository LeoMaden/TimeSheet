using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetLibrary.Models;
using TimeSheetLibrary;
using TimeSheetLibrary.Misc;

namespace FormUI
{
    public partial class LogPayForm : Form
    {
        private Employment Employment;

        private List<TimeSheetEntry> HoursListViewItems;

        private List<PaymentEntry> PaymentsListViewItems;


        public LogPayForm(Employment employment)
        {
            InitializeComponent();
            Employment = employment;
        }

        private void LogPayForm_Load(object sender, EventArgs e)
        {
            HoursListViewBox.ListViewItemSorter = new TimeSheetComparer();
            PayListViewBox.ListViewItemSorter = new PaymentEntryComparer();

            EmploymentNameLabel.Text = Employment.CompanyName;
            SelectedDateLabel.Text = PayDateSelector.SelectionStart.ToShortDateString();

            PopulateHoursListView();
            PopulatePayListView();


            // Select first item in PayListViewBox.
            foreach (ListViewItem item in PayListViewBox.Items)
            {
                item.Selected = true;
            }
        }

        private void PopulatePayListView()
        {
            PayListViewBox.Items.Clear();
            PaymentsListViewItems = Employment.PaymentEntries;

            for (int i = 0; i < PaymentsListViewItems.Count; i++)
            {
                PaymentEntry entry = PaymentsListViewItems[i];

                string[] cols =
                {
                    entry.Date.ToLongDateString(),
                    entry.HoursWorked.ToString(),
                    $"{entry.ExpectedPay:C2}",
                    $"{entry.ActualPay:C2}"
                };

                var listViewItem = new ListViewItem(cols);
                listViewItem.Tag = entry;

                PayListViewBox.Items.Add(listViewItem);
            }

            PayListViewBox.Sort();
        }

        private void PopulateHoursListView()
        {
            HoursListViewBox.Items.Clear();
            HoursListViewItems = Employment.TimeSheetEntries;

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

        private void HighlightLinkedHours()
        {
            List<TimeSheetEntry> linked;

            if (IsPaymentSelected() == false)
            {
                linked = new List<TimeSheetEntry>();
            }
            else
            {
                PaymentEntry selectedPayment = (PaymentEntry)PayListViewBox.SelectedItems[0].Tag;

                linked = GlobalConfig.Connection.GetLinkedHours(selectedPayment);
            }

            foreach (ListViewItem item in HoursListViewBox.Items)
            {
                TimeSheetEntry hoursEntry = (TimeSheetEntry)item.Tag;

                if (linked.Contains(hoursEntry, new TimeSheetComparer()) == true)
                {
                    item.BackColor = Color.Gray;
                    item.Checked = true;
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void PayListViewBox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Prevent columns resizing.
            e.Cancel = true;
            e.NewWidth = PayListViewBox.Columns[e.ColumnIndex].Width;
        }

        private void HoursListViewBox_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Prevent columns resizing.
            e.Cancel = true;
            e.NewWidth = HoursListViewBox.Columns[e.ColumnIndex].Width;
        }

        private void PayDateSelector_DateChanged(object sender, DateRangeEventArgs e)
        {
            SelectedDateLabel.Text = PayDateSelector.SelectionStart.ToShortDateString();
        }

        private void AddPaymentButton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(SelectedDateLabel.Text);

            PaymentEntry newEntry = new PaymentEntry();
            newEntry.Date = date;

            GlobalConfig.Connection.AddNewPaymentEntry(newEntry, Employment);

            PopulatePayListView();
        }

        private void DeletePaymentButton_Click(object sender, EventArgs e)
        {
            if (IsPaymentSelected() == false)
            {
                return;
            }

            PaymentEntry selected = (PaymentEntry)PayListViewBox.SelectedItems[0].Tag;

            List<TimeSheetEntry> links = GlobalConfig.Connection.GetLinkedHours(selected);

            if (links.Count != 0)
            {
                MessageBox.Show("Please unlink hours before deleting");
                return;
            }

            GlobalConfig.Connection.DeletePayment(selected);

            Employment.PaymentEntries.Remove(selected);
            PopulatePayListView();
        }

        private void LinkHoursPayButton_Click(object sender, EventArgs e)
        {
            if (IsPaymentSelected() == false)
            {
                return;
            }

            PaymentEntry selectedPayment = (PaymentEntry)PayListViewBox.SelectedItems[0].Tag;

            var selectedItems = HoursListViewBox.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                TimeSheetEntry hoursEntry = (TimeSheetEntry)item.Tag;

                if (item.Checked == false)
                {
                    GlobalConfig.Connection.AddPayHoursLink(selectedPayment, hoursEntry);
                    item.Checked = true;
                }
            }

            HighlightLinkedHours();

            UpdateExpectedValues();
        }

        private void UpdateExpectedValues()
        {
            PaymentEntry selectedPayment = (PaymentEntry)PayListViewBox.SelectedItems[0].Tag;

            List<TimeSheetEntry> hoursEntries = GlobalConfig.Connection.GetLinkedHours(selectedPayment);

            double hoursWorked = (from entry in hoursEntries
                                  select entry.HoursWorked).Sum();

            decimal expectedPay = (from entry in hoursEntries
                                   select ((decimal)entry.HoursWorked) * (entry.HourlyRate)).Sum();

            selectedPayment.HoursWorked = hoursWorked;
            selectedPayment.ExpectedPay = expectedPay;

            GlobalConfig.Connection.UpdatePaymentExpectedValues(selectedPayment);

            PopulatePayListView();
        }

        private void PayListViewBox_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            HighlightLinkedHours();

            if (IsPaymentSelected() == true)
            {
                PaymentEntry selected = (PaymentEntry)PayListViewBox.SelectedItems[0].Tag;

                ActualPayTextBox.Text = selected.ActualPay.ToString();
            }
        }

        private void UnlinkHoursPayButton_Click(object sender, EventArgs e)
        {
            if (IsPaymentSelected() == false)
            {
                return;
            }

            PaymentEntry selectedPayment = (PaymentEntry)PayListViewBox.SelectedItems[0].Tag;

            var selectedItems = HoursListViewBox.SelectedItems;

            foreach (ListViewItem item in selectedItems)
            {
                TimeSheetEntry hoursEntry = (TimeSheetEntry)item.Tag;

                if (item.Checked == true)
                {
                    GlobalConfig.Connection.DeletePayHoursLink(selectedPayment, hoursEntry);
                    item.Checked = false;
                }
            }

            HighlightLinkedHours();

            UpdateExpectedValues();
        }

        private bool IsPaymentSelected()
        {
            return PayListViewBox.SelectedIndices.Count != 0;
        }

        private void SetActualPayButton_Click(object sender, EventArgs e)
        {
            if (IsPaymentSelected() == false)
            {
                return;
            }

            bool validActualPay = decimal.TryParse(ActualPayTextBox.Text, out decimal actualPay);

            if (validActualPay == false)
            {
                MessageBox.Show("Invalid pay entered");
                return;
            }

            PaymentEntry selected = (PaymentEntry)PayListViewBox.SelectedItems[0].Tag;

            selected.ActualPay = actualPay;

            GlobalConfig.Connection.UpdatePaymentActualPay(selected);

            PopulatePayListView();
        }
    }
}
