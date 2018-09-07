using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeSheetLibrary.Models;

namespace TimeSheetLibrary.Misc
{
    public class PaymentEntryComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var first = (PaymentEntry)((ListViewItem)x).Tag;
            var second = (PaymentEntry)((ListViewItem)y).Tag;

            return second.Date.CompareTo(first.Date);
        }
    }
}
