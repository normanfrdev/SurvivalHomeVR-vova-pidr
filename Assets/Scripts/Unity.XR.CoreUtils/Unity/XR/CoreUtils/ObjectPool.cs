using System.Collections.Generic;

namespace Unity.XR.CoreUtils
{
	public class ObjectPool<T> where T : class, new()
	{
		protected readonly Queue<T> PooledQueue;

		public virtual T Get()
		{
			return null;
		}

		public void Recycle(T instance)
		{
		}

		protected virtual void ClearInstance(T instance)
		{
		}
	}
}
