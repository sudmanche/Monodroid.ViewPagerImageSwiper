using System;
using Android.Support.V4.App;
using Android.Support.V4.View;


namespace ImageSwiper.FullPager
{
    public class ContentPagerAdapter : FragmentStatePagerAdapter
    {
        private int count;

        public ContentPagerAdapter(FragmentManager fm, int itemCount)
            : base(fm)
        {
            count = itemCount;
        }

        public override int Count
        { get { return count; } }

        public override Fragment GetItem(int position)
        {
            return new PageFragment();
        }
    }
}