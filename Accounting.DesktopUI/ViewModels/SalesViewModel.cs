﻿using Accounting.DesktopUI.Library.Api;
using Accounting.DesktopUI.Library.Helpers;
using Accounting.DesktopUI.Library.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
		IProductEndpoint _productEndpoint;
		IConfigHelper _configHelper;
		public SalesViewModel(IProductEndpoint productEndpoint, IConfigHelper configHelper)
		{
			_productEndpoint = productEndpoint;
			_configHelper = configHelper;
		}

		protected override async void OnViewLoaded(object view)
		{
			base.OnViewLoaded(view);
			await LoadProducts();
		}

		private async Task LoadProducts()
		{
			var productList = await _productEndpoint.GetAll();
			Products = new BindingList<ProductModel>(productList);
		}

		private BindingList<ProductModel> _product;
		public BindingList<ProductModel> Products
		{
			get { return _product; }
			set 
			{ 
				_product = value;
				NotifyOfPropertyChange(() => Products);
			}
		}

		private ProductModel _selectedProduct;

		public ProductModel SelectedProduct
		{
			get { return _selectedProduct; }
			set 
			{
				_selectedProduct = value;
				NotifyOfPropertyChange(() => SelectedProduct);
			}
		}


		private BindingList<CartItemModel> _cart = new BindingList<CartItemModel>();
		public BindingList<CartItemModel> Cart
		{
			get { return _cart; }
			set 
			{ 
				_cart = value;
				NotifyOfPropertyChange(() => Cart);
			}
		}


		private int _itemQuantity = 1;
		public int ItemQuantity
		{
			get { return _itemQuantity; }
			set 
			{ 
				_itemQuantity = value;
				NotifyOfPropertyChange(() => ItemQuantity);
				NotifyOfPropertyChange(() => CanAddToCart);
			}
		}
		
		public string SubTotal
		{
			get 
			{
				return CalculateSubTotal().ToString("C"); 
			}
		}

		private decimal CalculateSubTotal()
		{
			decimal subTotal = 0;

			foreach (var item in Cart)
			{
				subTotal += (item.Product.RetailPrice * item.QuantityInCatr);
			}
			return subTotal;
		}

		public string Tax
		{
			get
			{
				return CalculateTax().ToString("C");
			}
		}

		private decimal CalculateTax()
		{
			decimal taxAmount = 0;
			decimal taxRate = _configHelper.GetTaxRate();

			foreach (var item in Cart)
			{
				if (item.Product.IsTaxable)
				{
					taxAmount += (item.Product.RetailPrice * item.QuantityInCatr * taxRate);
				}
			}
			return taxAmount;
		}

		public string Total
		{
			get
			{
				decimal total = CalculateSubTotal() + CalculateTax();
				return total.ToString("C");
			}
		}


		public bool CanAddToCart
		{
			get
			{
				bool output = false;

				if(ItemQuantity > 0 && SelectedProduct?.QuantityInStock >= ItemQuantity)
				{
					output = true;
				}

				return output;
			}
		}

		public void AddToCart()
		{
			CartItemModel existingItem = Cart.FirstOrDefault(x => x.Product == SelectedProduct);

			if(existingItem != null)
			{
				existingItem.QuantityInCatr += ItemQuantity;
				Cart.Remove(existingItem);
				Cart.Add(existingItem);
			}
			else
			{
				CartItemModel item = new CartItemModel
				{
					Product = SelectedProduct,
					QuantityInCatr = ItemQuantity
				};
				Cart.Add(item);
			}
			
			SelectedProduct.QuantityInStock -= ItemQuantity;
			ItemQuantity = 1;
			NotifyOfPropertyChange(() => SubTotal);
			NotifyOfPropertyChange(() => Tax);
			NotifyOfPropertyChange(() => Total);
		}

		public bool CanRemoveFromCart
		{
			get
			{
				bool output = false;

				//

				return output;
			}
		}

		public void RemoveFromCart()
		{
			NotifyOfPropertyChange(() => SubTotal);
			NotifyOfPropertyChange(() => Tax);
			NotifyOfPropertyChange(() => Total);
		}


		public bool CanCheckOut
		{
			get
			{
				bool output = false;

				//

				return output;
			}
		}

		public void CheckOut()
		{

		}

	}
}
