using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public struct OverrideLayer<T> : IDisposable
	{
		public readonly OverrideStack<T> stack
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal OverrideLayer(OverrideStack<T> stack, T item)
		{
		}

		public void Dispose()
		{
		}
	}
}
