using System.Reflection;

namespace Unity.VisualScripting
{
	public abstract class StaticFunctionInvokerBase<TResult> : StaticInvokerBase
	{
		protected StaticFunctionInvokerBase(MethodInfo methodInfo)
			: base(null)
		{
		}
	}
}
