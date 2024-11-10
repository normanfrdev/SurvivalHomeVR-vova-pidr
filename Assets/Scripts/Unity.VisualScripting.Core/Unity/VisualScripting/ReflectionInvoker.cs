using System;
using System.Reflection;

namespace Unity.VisualScripting
{
	public class ReflectionInvoker : IOptimizedInvoker
	{
		private readonly MethodInfo methodInfo;

		private static readonly object[] EmptyObjects;

		public ReflectionInvoker(MethodInfo methodInfo)
		{
		}

		public void Compile()
		{
		}

		public object Invoke(object target, params object[] args)
		{
			return null;
		}

		public object Invoke(object target)
		{
			return null;
		}

		public object Invoke(object target, object arg0)
		{
			return null;
		}

		public object Invoke(object target, object arg0, object arg1)
		{
			return null;
		}

		public object Invoke(object target, object arg0, object arg1, object arg2)
		{
			return null;
		}

		public object Invoke(object target, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		public object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4)
		{
			return null;
		}

		public Type[] GetParameterTypes()
		{
			return null;
		}
	}
}
