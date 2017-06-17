using System;
using Android.Support.V7.Widget;

namespace ListViewAndroidExperiments
{
    internal class CustomLayoutManager : LinearLayoutManager
    {
        private MainActivity mainActivity;

        public CustomLayoutManager(MainActivity mainActivity):base(mainActivity)
        {
            this.mainActivity = mainActivity;
        }

        public override RecyclerView.LayoutParams GenerateDefaultLayoutParams()
        {
            return new RecyclerView.LayoutParams(RecyclerView.LayoutParams.MatchParent,
                                                 RecyclerView.LayoutParams.MatchParent);
        }

        public override int Height
        {
            get
            {
                return 50;
            }
        }
    }
}