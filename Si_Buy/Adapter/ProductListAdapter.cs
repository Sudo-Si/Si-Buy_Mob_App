using System;
using Android.Support.V7.Widget;
using Android.Views;
using Si_Buy.Activities;
using static Si_Buy.Activities.ProductList;

namespace Si_Buy.Adapter
{
   
    class ProductListAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        private ProductList mProductList;

        public ProductListAdapter(ProductList productList)
        {
            mProductList = productList;
        }
        public override int ItemCount
        {
            get
            {
                return mProductList.numProduct;
            }
        }
        
        internal ProductList MPhotoAlbum { get => mProductList; set => mProductList = value; }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {

            ProductViewHolder pv = holder as ProductViewHolder;
            pv.Image.SetImageResource(mProductList[position].mProductID); 
            pv.Caption.Text = mProductList[position].mDescription;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.itemcard, parent, false);
            ProductViewHolder vh = new ProductViewHolder(itemView, OnClick);
            return vh;
        }
        private void OnClick(int obj)
        {
            if (ItemClick != null)
                ItemClick(this, obj);
        }

    }
}