using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Si_Buy.Adapter;

namespace Si_Buy.Activities
{
    [Activity(Label = "ItemActivity")]//, Theme ="AppTheme")]//, Theme = "AppTheme", MainLauncher = false)]
    public class ItemActivity : AppCompatActivity
    {

        RecyclerView mRecycleView;
        RecyclerView.LayoutManager mLayoutManager;
        ProductList mProductList;
        ProductListAdapter mAdapter;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(Resource.Layout.list_layout);
            //// Create your application here
            //mRecycleView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            //mLayoutManager = new LinearLayoutManager(this);
            //mRecycleView.SetLayoutManager(mLayoutManager);
            //mAdapter = new ProductListAdapter(mProductList);

            //mProductList = new ProductList();
            //mRecycleView.SetAdapter(mAdapter);

            mProductList = new ProductList();
            SetContentView(Resource.Layout.list_layout);
            mRecycleView = FindViewById<RecyclerView>(Resource.Id.recyclerView);

            mLayoutManager = new LinearLayoutManager(this);
            mRecycleView.SetLayoutManager(mLayoutManager);
            mAdapter = new ProductListAdapter(mProductList);
            mAdapter.ItemClick += MAdapter_ItemClick;


            mRecycleView.SetAdapter(mAdapter);



        }

        private void MAdapter_ItemClick(object sender, int e)
        {
            throw new NotImplementedException();
        }
    }
}