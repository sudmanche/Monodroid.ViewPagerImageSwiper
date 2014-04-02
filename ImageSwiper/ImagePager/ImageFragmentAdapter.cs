using Android.Support.V4.App;
using System.Collections.Generic;

namespace ImageSwiper.ImagePager
{
    public class ImageFragmentAdapter : FragmentStatePagerAdapter
    {
        private int count;

        public ImageFragmentAdapter(FragmentManager p0, int itemCount)
            : base(p0)
        {
            count = itemCount;
        }

        public override int Count
        { get { return count; } }

        public override Fragment GetItem(int position)
        {
            return new ImageFragment();
        }
    }
}