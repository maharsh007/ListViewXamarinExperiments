using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MyListViewExperiments
{
    public class TableViewSource : UITableViewSource
    {
        List<Sections> TableItems;
        protected string cellIdentifier = "EmbeddedTableCell";
        protected string secondcellIdentifier = "EmbeddedSecondTableCell";
        protected string headercellIdentifier = "HeaderCell";

        public TableViewSource(List<Sections> items)
        {
            TableItems = items;
        }

		public override nint NumberOfSections(UITableView tableView)
		{
            return TableItems.Count;
		}

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Section == 0)
                return 60;
            return 30;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if(!string.IsNullOrEmpty(TableItems[indexPath.Section].TextViews[indexPath.Row].MidLabelText))
            {
                var secondarycell = tableView.DequeueReusableCell(secondcellIdentifier) as EmbeddedSecondTableCell;
				TextViews seconditem = TableItems[indexPath.Section].TextViews[indexPath.Row];
				secondarycell.UpdateView(seconditem);
				return secondarycell;
            }
            var cell = tableView.DequeueReusableCell(cellIdentifier) as EmbeddedTableCell;
            TextViews item = TableItems[indexPath.Section].TextViews[indexPath.Row];
            cell.UpdateView(item);
			return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return TableItems[(int)section].TextViews.Count;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            if (section == 2)
            {
                return BuildSectionHeaderView(TableItems[(int)section].SectionHeader);
            }
            else
            {
                var headercell = tableView.DequeueReusableCell(headercellIdentifier) as HeaderCell;
                headercell.UpdateHeader(TableItems[(int)section].SectionHeader);
                return headercell;
            }
        }

        public override nfloat GetHeightForHeader(UITableView tableView, nint section)
        {
            return 60;
        }

		public static UIView BuildSectionHeaderView(string caption)
		{
			UIView view = new UIView(new System.Drawing.RectangleF(0, 0, 320, 20));
			view.BackgroundColor = UIColor.White;

			UILabel label = new UILabel();
			label.Opaque = false;
			label.TextColor = UIColor.FromRGB(190, 0, 0);
			label.Font = UIFont.FromName("Helvetica-Bold", 16f);
			label.Frame = new System.Drawing.RectangleF(5, 10, 315, 20);
			label.Text = caption;
			view.AddSubview(label);
			return view;
		}

    }
}
