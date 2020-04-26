using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Si_Buy.Activities
{
    public class Product
    {
        public int mProductID { get; set; }
        public string mDescription { get; set; }
    }
    class ProductList
    {
        static Product[] listProduct =
       {
            new Product() {mProductID = Resource.Drawable.Ex1, mDescription = "Ex1"},
            new Product() {mProductID = Resource.Drawable.Ex2, mDescription = "comp2"},
            new Product() {mProductID = Resource.Drawable.Ex3, mDescription = "ipad1"},

        };


        private Product[] products;
        Random random;
        public ProductList()
        {
            this.products = listProduct;
            random = new Random();
        }
        public int numProduct
        {
            get
            {
                return products.Length;
            }
        }
        public Product this[int i]
        {
            get { return products[i]; }
        }

        public class ProductViewHolder : RecyclerView.ViewHolder
        {
            public ImageView Image { get; set; }
            public TextView Caption { get; set; }
            public ProductViewHolder(View itemview, Action<int> listener) : base(itemview)
            {
                Image = itemview.FindViewById<ImageView>(Resource.Id.imageView);
                Caption = itemview.FindViewById<TextView>(Resource.Id.textView);
                itemview.Click += (sender, e) => listener(base.Position);
            }
        }
    }
}