using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lesan_Maria_Lab10.Models;


namespace Lesan_Maria_Lab10
{
    class ProductModel
    {
        private Product _oldProduct;

        public ObservableCollection<Product> Products { get; set; }

        public ProductModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Description = "Surface Book",
                    IsVisible = false,
                }
            };
        }

        public void ShowOrHidePoducts(Product product)
        {
            if (_oldProduct == product)
            {
                // click twice on the same item will hide it
                product.IsVisible = !product.IsVisible;
                UpdateProducts(product);
            }
            else
            {
                if (_oldProduct != null)
                {
                    // hide previous selected item
                    _oldProduct.IsVisible = false;
                    UpdateProducts(_oldProduct);
                }
                // show selected item
                product.IsVisible = true;
                UpdateProducts(product);
            }

            _oldProduct = product;
        }

        private void UpdateProducts(Product product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index, product);
        }
    }
}
    

