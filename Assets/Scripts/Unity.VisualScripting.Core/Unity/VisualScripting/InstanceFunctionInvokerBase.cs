using System.Reflection;

namespace Unity.VisualScripting
{
	public abstract class InstanceFunctionInvokerBase<TTarget, TResult> : InstanceInvokerBase<TTarget>
	{
		protected InstanceFunctionInvokerBase(MethodInfo methodInfo)
		{
			((InstanceInvokerBase<>)(object)this)._002Ector((MethodInfo)null);
		}
	}
}
