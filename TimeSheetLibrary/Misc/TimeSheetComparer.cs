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
    /// <summary>
    /// Comparer to sort items in the listview from most to least recent.
    /// </summary>
    public class TimeSheetComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var first = (TimeSheetEntry)((ListViewItem)x).Tag;
            var second = (TimeSheetEntry)((ListViewItem)y).Tag;

            return second.Date.CompareTo(first.Date);
        }
    }
}
