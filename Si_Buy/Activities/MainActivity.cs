using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Si_Buy.Activities;

namespace Si_Buy
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            textMessage = FindViewById<TextView>(Resource.Id.message);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
            //btnUpdateUser.Click += delegate { StartActivity(typeof(UpdateUserDetailsActivity)); };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                  //  SetContentView(Resource.Layout.activity_main);
                    StartActivity(typeof(MainActivity));
                    textMessage.SetText(Resource.String.title_home);
                    return true;
                case Resource.Id.navigation_location:
                  //  SetContentView(Resource.Layout.activity_main);
                    textMessage.SetText(Resource.String.title_location);
                    StartActivity(typeof(LocationActivity));
                    return true;
                case Resource.Id.navigation_profile:
                    //SetContentView(Resource.Layout.profile_layout);
                    textMessage.SetText(Resource.String.title_profile);
                    StartActivity(typeof(UserActivity));
                    return true;

                case Resource.Id.navigation_Items:
                    //SetContentView(Resource.Layout.item_layout);
                    textMessage.SetText(Resource.String.title_items);
                    StartActivity(typeof(ItemActivity));
                    return true;
            }
            return false;
        }
    }
}

