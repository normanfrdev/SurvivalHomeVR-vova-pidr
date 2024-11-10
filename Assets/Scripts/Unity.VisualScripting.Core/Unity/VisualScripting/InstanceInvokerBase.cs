using System.Linq.Expressions;
using System.Reflection;

namespace Unity.VisualScripting
{
	public abstract class InstanceInvokerBase<TTarget> : InvokerBase
	{
		protected InstanceInvokerBase(MethodInfo methodInfo)
			: base(null)
		{
		}

		protected sealed override void CompileExpression()
		{
		}

		protected abstract void CompileExpression(MethodCallExpression callExpression, ParameterExpression[] parameterExpressions);

		protected override void VerifyTarget(object target)
		{
		}
	}
}
