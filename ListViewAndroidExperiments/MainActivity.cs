using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using static Android.Support.V7.Widget.RecyclerView;

namespace ListViewAndroidExperiments
{
    [Activity(Label = "MainActivity", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        List<TextViews> items = new List<TextViews>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            CreateTableItems();
        }

		protected void CreateTableItems()
		{
			List<TextViews> tableItem1 = new List<TextViews>();
			List<TextViews> tableItem2 = new List<TextViews>();
			List<TextViews> tableItem3 = new List<TextViews>();
			tableItem1.Add(new TextViews() { Label = "Label1", LabelText = "1" });
			tableItem1.Add(new TextViews() { Label = "Label2", LabelText = "2" });
			tableItem1.Add(new TextViews() { Label = "Label3", LabelText = "3" });
			tableItem2.Add(new TextViews() { Label = "Label4", LabelText = "4", MidLabelText = "Mid" });
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
			var tableview = FindViewById<RecyclerView>(Resource.Id.recycler_view);
			tableview.SetAdapter(new CustomRecyclerAdapter(this,tableItem1));
            tableview.SetLayoutManager(new LinearLayoutManager(this));
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

