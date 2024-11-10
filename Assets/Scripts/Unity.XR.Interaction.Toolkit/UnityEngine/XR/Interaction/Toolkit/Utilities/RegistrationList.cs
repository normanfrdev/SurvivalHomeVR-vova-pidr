using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal class RegistrationList<T> : BaseRegistrationList<T>
	{
		private readonly HashSet<T> m_UnorderedBufferedAdd;

		private readonly HashSet<T> m_UnorderedBufferedRemove;

		private readonly HashSet<T> m_UnorderedRegisteredSnapshot;

		private readonly HashSet<T> m_UnorderedRegisteredItems;

		public override bool IsRegistered(T item)
		{
			return false;
		}

		public override bool IsStillRegistered(T item)
		{
			return false;
		}

		public override bool Register(T item)
		{
			return false;
		}

		public override bool Unregister(T item)
		{
			return false;
		}

		public override void Flush()
		{
		}

		public override void GetRegisteredItems(List<T> results)
		{
		}

		public override T GetRegisteredItemAt(int index)
		{
			return default(T);
		}

		protected override void OnItemMovedImmediately(T item, int newIndex)
		{
		}

		public RegistrationList()
		{
			((BaseRegistrationList<>)(object)this)._002Ector();
		}
	}
}
