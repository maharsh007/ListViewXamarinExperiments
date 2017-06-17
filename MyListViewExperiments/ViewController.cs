using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MyListViewExperiments
{
    public partial class ViewController : UIViewController
    {
        static NSString EmbeddedTableCell = new NSString("EmbeddedTableCell");
        List<TextViews> items = new List<TextViews>();

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            CreateTableItems();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

		protected void CreateTableItems()
		{
			List<TextViews> tableItem1 = new List<TextViews>();
            List<TextViews> tableItem2 = new List<TextViews>();
            List<TextViews> tableItem3 = new List<TextViews>();
            tableItem1.Add(new TextViews() { Label= "Label1",LabelText= "1" });
			tableItem1.Add(new TextViews() { Label = "Label2", LabelText = "2" });
			tableItem1.Add(new TextViews() { Label = "Label3", LabelText = "3" });
            tableItem2.Add(new TextViews() { Label = "Label4", LabelText = "4",MidLabelText="Mid" });
			tableItem2.Add(new TextViews() { Label = "Label5", LabelText = "5" });
			tableItem2.Add(new TextViews() { Label = "Label6", LabelText = "6" });
			tableItem3.Add(new TextViews() { Label = "Label7", LabelText = "7" });
			tableItem3.Add(new TextViews() { Label = "Label8", LabelText = "8" });
			tableItem3.Add(new TextViews() { Label = "Label9", LabelText = "9" });

            List<Sections> sections = new List<Sections>();
            sections.Add(new Sections()
            {
                SectionHeader = "First Header",
                TextViews = tableItem1
            });
			sections.Add(new Sections()
			{
				SectionHeader = "Second Header",
				TextViews = tableItem2
			});
			sections.Add(new Sections()
			{
				SectionHeader = "Third Header",
				TextViews = tableItem3
			});
            TextViewTableView.Source = new TableViewSource(sections);
            View.BackgroundColor = UIColor.White;
            TextViewTableView.ReloadData();
		}

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

	}

    public class TextViews
    {
        public string Label { get; set; }

        public string LabelText { get; set; }

        public string MidLabelText { get; set; }
    }

    public class Sections
    {
        public string SectionHeader { get; set; }

        public List<TextViews> TextViews { get; set; }
    }
}
