using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class UnexpectedEnumValueException<T> : Exception
	{
		public T Value
		{
			[CompilerGenerated]
			get
			{
				return default(T);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public UnexpectedEnumValueException(T value)
		{
		}
	}
}
