using System;
using System.Diagnostics;

namespace Unity.VisualScripting.Antlr3.Runtime.Misc
{
	public class ErrorManager
	{
		public static void InternalError(object error, Exception e)
		{
		}

		public static void InternalError(object error)
		{
		}

		private static StackFrame GetLastNonErrorManagerCodeLocation(Exception e)
		{
			return null;
		}

		public static void Error(object arg)
		{
		}
	}
}
