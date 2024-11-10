using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.InputSystem.LowLevel
{
	[StructLayout(LayoutKind.Explicit, Size = 132)]
	public struct IMECompositionString : IEnumerable<char>, IEnumerable
	{
		internal struct Enumerator : IEnumerator<char>, IEnumerator, IDisposable
		{
			private IMECompositionString m_CompositionString;

			private char m_CurrentCharacter;

			private int m_CurrentIndex;

			public char Current => '\0';

			object IEnumerator.Current => null;

			public Enumerator(IMECompositionString compositionString)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		[FieldOffset(0)]
		private int size;

		[FieldOffset(4)]
		private unsafe fixed char buffer[64];

		public int Count => 0;

		public char this[int index] => '\0';

		public IMECompositionString(string characters)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public IEnumerator<char> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
