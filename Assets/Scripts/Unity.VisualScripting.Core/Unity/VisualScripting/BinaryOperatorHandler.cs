using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.VisualScripting
{
	public abstract class BinaryOperatorHandler : OperatorHandler
	{
		private struct OperatorQuery : IEquatable<OperatorQuery>
		{
			public readonly Type leftType;

			public readonly Type rightType;

			public OperatorQuery(Type leftType, Type rightType)
			{
			}

			public bool Equals(OperatorQuery other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		private readonly Dictionary<OperatorQuery, Func<object, object, object>> handlers;

		private readonly Dictionary<OperatorQuery, IOptimizedInvoker> userDefinedOperators;

		private readonly Dictionary<OperatorQuery, OperatorQuery> userDefinedOperandTypes;

		protected BinaryOperatorHandler(string name, string verb, string symbol, string customMethodName)
			: base(null, null, null, null)
		{
		}

		public virtual object Operate(object leftOperand, object rightOperand)
		{
			return null;
		}

		protected virtual object CustomHandling(object leftOperand, object rightOperand)
		{
			return null;
		}

		protected virtual object BothNullHandling()
		{
			return null;
		}

		protected virtual object SingleNullHandling()
		{
			return null;
		}

		protected void Handle<TLeft, TRight>(Func<TLeft, TRight, object> handler, bool reverse = false)
		{
		}

		private static OperatorQuery ResolveUserDefinedOperandTypes(MethodInfo userDefinedOperator)
		{
			return default(OperatorQuery);
		}
	}
}
