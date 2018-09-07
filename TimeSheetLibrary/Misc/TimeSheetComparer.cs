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
    public class TimeSheetComparer : IComparer, IEqualityComparer<TimeSheetEntry>
    {
        public int Compare(object x, object y)
        {
            var first = (TimeSheetEntry)((ListViewItem)x).Tag;
            var second = (TimeSheetEntry)((ListViewItem)y).Tag;

            return second.Date.CompareTo(first.Date);
        }

        public bool Equals(TimeSheetEntry x, TimeSheetEntry y)
        {
            return x.ID == y.ID;
        }

        public int GetHashCode(TimeSheetEntry obj)
        {
            throw new NotImplementedException();
        }
    }
}
