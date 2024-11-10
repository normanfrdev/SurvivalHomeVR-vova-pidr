using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public struct NoAllocEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable
	{
		private readonly IList<T> list;

		private int index;

		private T current;

		private bool exceeded;

		public T Current => default(T);

		object IEnumerator.Current => null;

		public NoAllocEnumerator(IList<T> list)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}
}
