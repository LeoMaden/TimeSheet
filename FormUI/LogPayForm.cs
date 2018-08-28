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
    public partial class LogPayForm : Form
    {
        private Employment Employment;

        public LogPayForm(Employment employment)
        {
            InitializeComponent();
            Employment = employment;
        }

        private void LogPayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
