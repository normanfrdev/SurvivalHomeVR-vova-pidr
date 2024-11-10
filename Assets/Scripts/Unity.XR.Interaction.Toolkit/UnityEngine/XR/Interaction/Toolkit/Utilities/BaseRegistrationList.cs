using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal abstract class BaseRegistrationList<T>
	{
		private static readonly LinkedPool<List<T>> s_BufferedListPool;

		protected List<T> m_BufferedAdd;

		protected List<T> m_BufferedRemove;

		public List<T> registeredSnapshot
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int flushedCount => 0;

		protected int bufferedAddCount => 0;

		protected int bufferedRemoveCount => 0;

		protected void AddToBufferedAdd(T item)
		{
		}

		protected bool RemoveFromBufferedAdd(T item)
		{
			return false;
		}

		protected void ClearBufferedAdd()
		{
		}

		protected void AddToBufferedRemove(T item)
		{
		}

		protected bool RemoveFromBufferedRemove(T item)
		{
			return false;
		}

		protected void ClearBufferedRemove()
		{
		}

		public abstract bool IsRegistered(T item);

		public abstract bool IsStillRegistered(T item);

		public abstract bool Register(T item);

		public abstract bool Unregister(T item);

		public abstract void Flush();

		public abstract void GetRegisteredItems(List<T> results);

		public abstract T GetRegisteredItemAt(int index);

		public bool MoveItemImmediately(T item, int newIndex)
		{
			return false;
		}

		protected virtual void OnItemMovedImmediately(T item, int newIndex)
		{
		}

		public void UnregisterAll()
		{
		}

		protected static void EnsureCapacity(List<T> list, int capacity)
		{
		}
	}
}
