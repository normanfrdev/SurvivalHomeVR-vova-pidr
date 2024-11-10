using System.Linq.Expressions;
using System.Reflection;

namespace Unity.VisualScripting
{
	public abstract class StaticInvokerBase : InvokerBase
	{
		protected StaticInvokerBase(MethodInfo methodInfo)
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
