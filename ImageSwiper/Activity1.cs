using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using ImageSwiper.FullPager;
using ImageSwiper.UIControls;

namespace ImageSwiper
{
    [Activity(Label = "ImageSwiper", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : FragmentActivity
    {
        protected ContentPagerAdapter adapter;
        protected NestingViewPager pager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.PagerContainerLayout);
            //create adapter, specify 3 pages
            adapter = new ContentPagerAdapter(SupportFragmentManager, 3);

            pager = FindViewById<NestingViewPager>(Resource.Id.pager);
            pager.Adapter = adapter;
        }
    }
}

