using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Unity.VisualScripting
{
	public sealed class StaticActionInvoker : StaticActionInvokerBase
	{
		private Action invoke;

		public StaticActionInvoker(MethodInfo methodInfo)
			: base(null)
		{
		}

		public override object Invoke(object target, params object[] args)
		{
			return null;
		}

		public override object Invoke(object target)
		{
			return null;
		}

		private object InvokeUnsafe(object target)
		{
			return null;
		}

		protected override Type[] GetParameterTypes()
		{
			return null;
		}

		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions)
		{
		}

		protected override void CreateDelegate()
		{
		}
	}
	public sealed class StaticActionInvoker<TParam0> : StaticActionInvokerBase
	{
		private Action<TParam0> invoke;

		public StaticActionInvoker(MethodInfo methodInfo)
			: base(null)
		{
		}

		public override object Invoke(object target, params object[] args)
		{
			return null;
		}

		public override object Invoke(object target, object arg0)
		{
			return null;
		}

		private object InvokeUnsafe(object target, object arg0)
		{
			return null;
		}

		protected override Type[] GetParameterTypes()
		{
			return null;
		}

		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions)
		{
		}

		protected override void CreateDelegate()
		{
		}
	}
	public sealed class StaticActionInvoker<TParam0, TParam1> : StaticActionInvokerBase
	{
		private Action<TParam0, TParam1> invoke;

		public StaticActionInvoker(MethodInfo methodInfo)
			: base(null)
		{
		}

		public override object Invoke(object target, params object[] args)
		{
			return null;
		}

		public override object Invoke(object target, object arg0, object arg1)
		{
			return null;
		}

		public object InvokeUnsafe(object target, object arg0, object arg1)
		{
			return null;
		}

		protected override Type[] GetParameterTypes()
		{
			return null;
		}

		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions)
		{
		}

		protected override void CreateDelegate()
		{
		}
	}
	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2> : StaticActionInvokerBase
	{
		private Action<TParam0, TParam1, TParam2> invoke;

		public StaticActionInvoker(MethodInfo methodInfo)
			: base(null)
		{
		}

		public override object Invoke(object target, params object[] args)
		{
			return null;
		}

		public override object Invoke(object target, object arg0, object arg1, object arg2)
		{
			return null;
		}

		public object InvokeUnsafe(object target, object arg0, object arg1, object arg2)
		{
			return null;
		}

		protected override Type[] GetParameterTypes()
		{
			return null;
		}

		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions)
		{
		}

		protected override void CreateDelegate()
		{
		}
	}
	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3> : StaticActionInvokerBase
	{
		private Action<TParam0, TParam1, TParam2, TParam3> invoke;

		public StaticActionInvoker(MethodInfo methodInfo)
			: base(null)
		{
		}

		public override object Invoke(object target, params object[] args)
		{
			return null;
		}

		public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		protected override Type[] GetParameterTypes()
		{
			return null;
		}

		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions)
		{
		}

		protected override void CreateDelegate()
		{
		}
	}
	public sealed class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4> : StaticActionInvokerBase
	{
		private Action<TParam0, TParam1, TParam2, TParam3, TParam4> invoke;

		public StaticActionInvoker(MethodInfo methodInfo)
			: base(null)
		{
		}

		public override object Invoke(object target, params object[] args)
		{
			return null;
		}

		public override object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4)
		{
			return null;
		}

		public object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4)
		{
			return null;
		}

		protected override Type[] GetParameterTypes()
		{
			return null;
		}

		protected override void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions)
		{
		}

		protected override void CreateDelegate()
		{
		}
	}
}
