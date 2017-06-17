using Foundation;
using System;
using UIKit;

namespace MyListViewExperiments
{
    public partial class EmbeddedTableCell : UITableViewCell
    {
		public static readonly NSString Key = new NSString("EmbeddedTableCell");
		public static readonly UINib Nib;

		static EmbeddedTableCell()
		{
			Nib = UINib.FromName("EmbeddedTableCell", NSBundle.MainBundle);
		}

        public EmbeddedTableCell (IntPtr handle) : base (handle)
        {
        }

		internal void UpdateView(TextViews item)
		{
			KeyLabel.Text = item.Label;
			ValueLabel.Text = item.LabelText;
		}
    }
}