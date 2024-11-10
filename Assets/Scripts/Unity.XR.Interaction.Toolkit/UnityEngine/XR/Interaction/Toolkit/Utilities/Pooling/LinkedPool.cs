using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling
{
	internal class LinkedPool<T> : IDisposable where T : class
	{
		internal class LinkedPoolItem
		{
			internal LinkedPoolItem poolNext;

			internal T value;
		}

		private readonly Func<T> m_CreateFunc;

		private readonly Action<T> m_ActionOnGet;

		private readonly Action<T> m_ActionOnRelease;

		private readonly Action<T> m_ActionOnDestroy;

		private readonly int m_Limit;

		private LinkedPoolItem m_PoolFirst;

		private LinkedPoolItem m_NextAvailableListItem;

		private readonly bool m_CollectionCheck;

		public int countInactive
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LinkedPool(Func<T> createFunc, Action<T> actionOnGet = null, Action<T> actionOnRelease = null, Action<T> actionOnDestroy = null, bool collectionCheck = true, int maxSize = 10000)
		{
		}

		public T Get()
		{
			return null;
		}

		public PooledObject<T> Get(out T v)
		{
			v = null;
			return default(PooledObject<T>);
		}

		public void Release(T item)
		{
		}

		public void Clear()
		{
		}

		public void Dispose()
		{
		}
	}
}
