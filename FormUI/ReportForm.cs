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

namespace FormUI
{
    public partial class ReportForm : Form
    {
        private string Title;

        private IEnumerable<IDictionary<string, object>> Data;

        public ReportForm(string reportName, IEnumerable<IDictionary<string, object>> data)
        {
            InitializeComponent();
            Title = reportName;
            Data = data;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            Text = Title;
            ReportTitle.Text = Title + " Report";
            PopulateListView();
        }

        private void PopulateListView()
        {

            List<string> columns = Data.First().Keys.ToList();

            foreach (var col in columns)
            {
                int dataLength;

                if (Data.First()[col] is DateTime date)
                {
                    dataLength = date.ToLongDateString().Length;
                }
                else
                {
                    dataLength = Data.First()[col].ToString().Length;
                }

                int titleLength = col.Length;

                int len = Math.Max(dataLength, titleLength);

                ReportListView.Columns.Add(col, len * 10);
            }

            foreach (var row in Data)
            {
                var values = row.Values;
                List<string> rowData = new List<string>();

                for (int i = 0; i < ReportListView.Columns.Count; i++)
                {
                    object element = values.ElementAt(i);
                    string value;

                    if (element is DateTime date)
                    {
                        value = date.ToLongDateString();
                    }
                    else
                    {
                        value = element.ToString();
                    }

                    rowData.Add(value);
                }

                ReportListView.Items.Add(new ListViewItem(rowData.ToArray()));
            }
        }
    }
}
