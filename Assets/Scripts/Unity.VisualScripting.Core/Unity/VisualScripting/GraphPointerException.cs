using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class GraphPointerException : Exception
	{
		public GraphPointer pointer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public GraphPointerException(string message, GraphPointer pointer)
		{
		}
	}
}
