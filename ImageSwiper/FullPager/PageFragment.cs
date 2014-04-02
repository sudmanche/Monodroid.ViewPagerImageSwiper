using System;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Widget;
using Android.Views;
using Android.OS;
using ImageSwiper.ImagePager;

namespace ImageSwiper.FullPager
{

    public class PageFragment : Android.Support.V4.App.Fragment
    {
        protected ImageFragmentAdapter imageAdapter;
        protected ViewPager imagePager;
        protected ImageView imageView;

        private string fragId = "pageFragment";

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            //inflate view
            View itemView = inflater.Inflate(Resource.Layout.PagerItemFragment, container, false);
            imagePager = itemView.FindViewById<ViewPager>(Resource.Id.imagePager);

            //create adapter, 3 images
            imageAdapter = new ImageFragmentAdapter(Activity.SupportFragmentManager, 3);
            imagePager.Adapter = imageAdapter;

            return itemView;
        }
        
    }
}
