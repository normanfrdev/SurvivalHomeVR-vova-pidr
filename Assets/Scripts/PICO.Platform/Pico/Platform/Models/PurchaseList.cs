using System;

namespace Pico.Platform.Models
{
	public class PurchaseList : MessageArray<Purchase>
	{
		public PurchaseList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
