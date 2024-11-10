using System;
using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class IAPService
	{
		public static Task ConsumePurchase(string sku)
		{
			return null;
		}

		public static Task<ProductList> GetProductsBySKU(string[] skus)
		{
			return null;
		}

		public static Task<PurchaseList> GetViewerPurchases()
		{
			return null;
		}

		[Obsolete("Please use LaunchCheckoutFlow2(Product product)", false)]
		public static Task<Purchase> LaunchCheckoutFlow(string sku, string price, string currency)
		{
			return null;
		}

		public static Task<Purchase> LaunchCheckoutFlow2(Product product)
		{
			return null;
		}

		public static Task<Purchase> LaunchCheckoutFlow3(Product product, string orderComment)
		{
			return null;
		}

		public static Task<SubscriptionStatus> GetSubscriptionStatus(string sku)
		{
			return null;
		}

		public static Task<ProductList> GetNextProductListPage(ProductList list)
		{
			return null;
		}

		public static Task<PurchaseList> GetNextPurchaseListPage(PurchaseList list)
		{
			return null;
		}
	}
}
