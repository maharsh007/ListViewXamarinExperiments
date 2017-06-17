using Foundation;
using System;
using UIKit;

namespace MyListViewExperiments
{
    public partial class EmbeddedSecondTableCell : UITableViewCell
    {
		public static readonly NSString Key = new NSString("EmbeddedSecondTableCell");
		public static readonly UINib Nib;

		static EmbeddedSecondTableCell()
		{
			Nib = UINib.FromName("EmbeddedSecondTableCell", NSBundle.MainBundle);
		}

		public EmbeddedSecondTableCell (IntPtr handle) : base (handle)
        {
        }

		internal void UpdateView(TextViews item)
		{
			KeyLabel.Text = item.Label;
			ValueLabel.Text = item.LabelText;
            MidLabel.Text = item.MidLabelText;
		}
    }
}