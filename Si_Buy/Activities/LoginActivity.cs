using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;

namespace Si_Buy.Activities
{
    [Activity(Label = "LoginActivity", Theme = "@style/AppTheme", MainLauncher = false)]
    public class LoginActivity : Activity
    {
        Button btnLogin;

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            throw new NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);
            btnLogin = FindViewById<Button>(Resource.Id.btn_login);
           btnLogin.Click += BtnLogin_Click;
           
            //  btnLogin.Click +=delegate { StartActivity(typeof(MainActivity)); };
            // Create your application here
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
           //StartActivity(typeof(MainActivity));

            SetContentView(Resource.Layout.activity_main);
        }
    }
}