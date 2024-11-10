using System;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class OverrideStack<T>
	{
		private readonly Func<T> getValue;

		private readonly Action<T> setValue;

		private readonly Action clearValue;

		private T _value;

		private readonly Stack<T> previous;

		public T value
		{
			get
			{
				return default(T);
			}
			internal set
			{
			}
		}

		public OverrideStack(T defaultValue)
		{
		}

		public OverrideStack(Func<T> getValue, Action<T> setValue)
		{
		}

		public OverrideStack(Func<T> getValue, Action<T> setValue, Action clearValue)
		{
		}

		public OverrideLayer<T> Override(T item)
		{
			return default(OverrideLayer<T>);
		}

		public void BeginOverride(T item)
		{
		}

		public void EndOverride()
		{
		}

		public static implicit operator T(OverrideStack<T> stack)
		{
			return default(T);
		}
	}
}
