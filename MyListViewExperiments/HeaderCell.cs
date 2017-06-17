using Foundation;
using System;
using UIKit;

namespace MyListViewExperiments
{
    public partial class HeaderCell : UITableViewCell
    {
        public HeaderCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateHeader(string sectionHeader)
        {
            SectionHeader.Text = sectionHeader;
        }
    }
}