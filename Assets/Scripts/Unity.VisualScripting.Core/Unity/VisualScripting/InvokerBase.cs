using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Unity.VisualScripting
{
	public abstract class InvokerBase : IOptimizedInvoker
	{
		protected readonly Type targetType;

		protected readonly MethodInfo methodInfo;

		protected InvokerBase(MethodInfo methodInfo)
		{
		}

		protected void VerifyArgument<TParam>(MethodInfo methodInfo, int argIndex, object arg)
		{
		}

		public void Compile()
		{
		}

		protected ParameterExpression[] GetParameterExpressions()
		{
			return null;
		}

		protected abstract Type[] GetParameterTypes();

		public abstract object Invoke(object target, params object[] args);

		public virtual object Invoke(object target)
		{
			return null;
		}

		public virtual object Invoke(object target, object arg0)
		{
			return null;
		}

		public virtual object Invoke(object target, object arg0, object arg1)
		{
			return null;
		}

		public virtual object Invoke(object target, object arg0, object arg1, object arg2)
		{
			return null;
		}

		public virtual object Invoke(object target, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		public virtual object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4)
		{
			return null;
		}

		protected abstract void CompileExpression();

		protected abstract void CreateDelegate();

		protected abstract void VerifyTarget(object target);
	}
}
