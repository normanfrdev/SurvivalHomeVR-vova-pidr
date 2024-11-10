using System.Collections.Generic;

namespace Pico.Platform.Models
{
	public class MessageArray<T> : List<T>
	{
		public string NextPageParam;

		public string PreviousPageParam;

		public bool HasNextPage => false;

		public bool HasPreviousPage => false;

		public MessageArray()
		{
			((List<T>)(object)this)._002Ector();
		}
	}
}
