using System.Collections;
using System.Collections.Generic;

namespace Unity.XR.CoreUtils.Collections
{
	public class ReadOnlyList<T> : IReadOnlyList<T>, IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
	{
		private readonly List<T> m_List;

		public int Count => 0;

		public T this[int index] => default(T);

		public ReadOnlyList(List<T> list)
		{
		}

		public List<T>.Enumerator GetEnumerator()
		{
			return default(List<T>.Enumerator);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
