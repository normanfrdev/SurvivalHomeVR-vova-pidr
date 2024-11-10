using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Filtering;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal class ExposedRegistrationList<T> : SmallRegistrationList<T>, IXRFilterList<T> where T : class
	{
		public int count => 0;

		public void Add(T item)
		{
		}

		public bool Remove(T item)
		{
			return false;
		}

		public void MoveTo(T item, int newIndex)
		{
		}

		public void Clear()
		{
		}

		public void GetAll(List<T> results)
		{
		}

		public T GetAt(int index)
		{
			return null;
		}

		public void RegisterReferences<TObject>(List<TObject> references, Object context = null) where TObject : Object
		{
		}

		public ExposedRegistrationList()
		{
			((SmallRegistrationList<>)(object)this)._002Ector();
		}
	}
}
