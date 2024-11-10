using System.Collections.Generic;

namespace Unity.VisualScripting.Antlr3.Runtime.Collections
{
	public class StackList : List<object>
	{
		public StackList()
		{
			((List<T>)(object)this)._002Ector();
		}

		public void Push(object item)
		{
		}

		public object Pop()
		{
			return null;
		}

		public object Peek()
		{
			return null;
		}
	}
}
