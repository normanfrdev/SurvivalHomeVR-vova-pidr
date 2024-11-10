using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal class SmallRegistrationList<T> : BaseRegistrationList<T>
	{
		private bool m_BufferChanges;

		public bool bufferChanges
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public SmallRegistrationList()
		{
			((BaseRegistrationList<>)(object)this)._002Ector();
		}
	}
}
