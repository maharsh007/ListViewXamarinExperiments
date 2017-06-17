using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace ListViewAndroidExperiments
{
    internal class CustomRecyclerAdapter : RecyclerView.Adapter
    {
        private List<TextViews> items;
        MainActivity context;

        public CustomRecyclerAdapter(MainActivity context,List<TextViews> items)
        {
            this.context = context;
            this.items = items;
        }

		public class ViewHolder : RecyclerView.ViewHolder
		{
			public TextView keyTextView;
			public TextView valueTextView;

            public ViewHolder(View itemView):base(itemView)
            {
                keyTextView = itemView.FindViewById<TextView>(Resource.Id.StartLabel);
                valueTextView = itemView.FindViewById<TextView>(Resource.Id.EndLabel);
            }
    	}



        public override int ItemCount => items.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            TextViews textview = items[position];
			// Set item views based on your views and data model
            TextView keytextView = (holder as ViewHolder).keyTextView;
            keytextView.Text = textview.Label;
			TextView valuetextView = (holder as ViewHolder).valueTextView;
            valuetextView.Text = textview.LabelText;

        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            LayoutInflater inflater = context.LayoutInflater;

			// Inflate the custom layout
            View contactView = inflater.Inflate(Resource.Layout.itemscell, parent, false);
			// Return a new holder instance
			ViewHolder viewHolder = new ViewHolder(contactView);
			return viewHolder;
        }
    }
}