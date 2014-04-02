using Android.Content;
using Android.Support.V4.View;
using Android.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageSwiper.UIControls
{
    public class NestingViewPager : ViewPager
    {
        public NestingViewPager(Context context, IAttributeSet attrs) : base(context, attrs)
        {}

        public NestingViewPager(Context context)  : base(context)
        {}

        public override bool OnInterceptTouchEvent(Android.Views.MotionEvent ev)
        {
            //this is a bit of a hack, in that it only checks for the specific imagePager, maybe could use a TAG
            ViewPager pager = FindViewById<ViewPager>(Resource.Id.imagePager);

            if (pager != null)
            {
                pager.RequestDisallowInterceptTouchEvent(true);
            }

            return base.OnInterceptTouchEvent(ev);
        }
    }
}
