using System.Collections.Generic;

namespace Unity.XR.CoreUtils
{
	public static class CollectionPool<TCollection, TValue> where TCollection : ICollection<TValue>, new()
	{
		private static readonly Queue<TCollection> k_CollectionQueue;

		public static TCollection GetCollection()
		{
			return default(TCollection);
		}

		public static void RecycleCollection(TCollection collection)
		{
		}
	}
}
