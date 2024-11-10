using System;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public sealed class GraphStack : GraphPointer, IPoolable, IDisposable
	{
		private GraphStack()
		{
		}

		private void InitializeNoAlloc(IGraphRoot root, List<IGraphParentElement> parentElements, bool ensureValid)
		{
		}

		internal static GraphStack New(IGraphRoot root, List<IGraphParentElement> parentElements)
		{
			return null;
		}

		internal static GraphStack New(GraphPointer model)
		{
			return null;
		}

		public GraphStack Clone()
		{
			return null;
		}

		public void Dispose()
		{
		}

		void IPoolable.New()
		{
		}

		void IPoolable.Free()
		{
		}

		public override GraphReference AsReference()
		{
			return null;
		}

		public GraphReference ToReference()
		{
			return null;
		}

		internal void ClearReference()
		{
		}

		public new void EnterParentElement(IGraphParentElement parentElement)
		{
		}

		public bool TryEnterParentElement(IGraphParentElement parentElement)
		{
			return false;
		}

		public bool TryEnterParentElementUnsafe(IGraphParentElement parentElement)
		{
			return false;
		}

		public new void ExitParentElement()
		{
		}
	}
}
