using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Si_Buy.Activities;
using Si_Buy.Adapter;
using System;

namespace Si_Buy
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        Button btnUpdateUser;
        TextView textMessage;
        RecyclerView mRecycleView;
        RecyclerView.LayoutManager mLayoutManager;
        ProductList mProductList;
        ProductListAdapter mAdapter;

        //RecyclerView mRecycleView;
        //RecyclerView.LayoutManager mLayoutManager;
        //ProductList mProductList;
        //ProductListAdapter mAdapter;

        public EventHandler<int> MAdapter_ItemClick { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
         //   SetContentView(Resource.Layout.activity_login);
            SetContentView(Resource.Layout.activity_main);
            textMessage = FindViewById<TextView>(Resource.Id.message);
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
            btnUpdateUser = FindViewById<Button>(Resource.Id.btn1);
            btnUpdateUser.Click += BtnUpdateUser_Click; ;
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            //  StartActivity(typeof(ItemActivity));
        
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
                   // SetContentView(Resource.Layout.location_layout);
                    return true;
                case Resource.Id.navigation_profile:
                    //SetContentView(Resource.Layout.profile_layout);
                    textMessage.SetText(Resource.String.title_profile);
                    StartActivity(typeof(UserActivity));
                    return true;

                case Resource.Id.navigation_Items:
                    SetContentView(Resource.Layout.list_layout);
                    StartActivity(typeof(ItemActivity));
                    // Set our view from the "main" layout resource
                    SetContentView(Resource.Layout.list_layout);
                
                    return true;
            }
            return false;
        }
    }
}

