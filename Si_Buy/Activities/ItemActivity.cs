using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Si_Buy.Activities
{
    [Activity(Label = "ItemActivity")]//, Theme ="AppTheme")]//, Theme = "AppTheme", MainLauncher = false)]
    public class ItemActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.item_layout);
            // Create your application here
        }
    }
}