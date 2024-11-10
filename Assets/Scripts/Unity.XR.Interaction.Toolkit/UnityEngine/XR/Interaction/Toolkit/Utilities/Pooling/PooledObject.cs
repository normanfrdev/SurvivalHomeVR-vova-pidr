using System;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling
{
	internal readonly struct PooledObject<T> : IDisposable where T : class
	{
		private readonly T m_ToReturn;

		private readonly LinkedPool<T> m_Pool;

		internal PooledObject(T value, LinkedPool<T> pool)
		{
		}

		void IDisposable.Dispose()
		{
		}
	}
}
