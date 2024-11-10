using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.VisualScripting
{
	public abstract class UnaryOperatorHandler : OperatorHandler
	{
		private readonly Dictionary<Type, Func<object, object>> manualHandlers;

		private readonly Dictionary<Type, IOptimizedInvoker> userDefinedOperators;

		private readonly Dictionary<Type, Type> userDefinedOperandTypes;

		protected UnaryOperatorHandler(string name, string verb, string symbol, string customMethodName)
			: base(null, null, null, null)
		{
		}

		public object Operate(object operand)
		{
			return null;
		}

		protected virtual object CustomHandling(object operand)
		{
			return null;
		}

		protected void Handle<T>(Func<T, object> handler)
		{
		}

		private static Type ResolveUserDefinedOperandType(MethodInfo userDefinedOperator)
		{
			return null;
		}
	}
}
