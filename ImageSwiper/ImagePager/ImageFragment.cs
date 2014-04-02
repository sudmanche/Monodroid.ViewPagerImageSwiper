using System.Text;
using Android.OS;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using Android.Graphics.Drawables;

namespace ImageSwiper.ImagePager
{
    public class ImageFragment : Fragment
    {
        public ImageView imageView;
        public LinearLayout layout;

        public ImageFragment()
        {
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View _view = inflater.Inflate(Resource.Layout.ImageFragment, container, false);

            imageView = _view.FindViewById<ImageView>(Resource.Id.imageView);
            imageView.SetImageResource(Resource.Drawable.Icon);

            return _view;
        }

        public override void OnResume()
        {
            base.OnResume();
        }
        
    }
}