using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class OptimizedReflection
	{
		private static readonly Dictionary<FieldInfo, IOptimizedAccessor> fieldAccessors;

		private static readonly Dictionary<PropertyInfo, IOptimizedAccessor> propertyAccessors;

		private static readonly Dictionary<MethodInfo, IOptimizedInvoker> methodInvokers;

		public static readonly bool jitAvailable;

		private static bool _useJitIfAvailable;

		internal static bool useJit => false;

		public static bool useJitIfAvailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool safeMode
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		static OptimizedReflection()
		{
		}

		internal static void OnRuntimeMethodLoad()
		{
		}

		public static void ClearCache()
		{
		}

		internal static void VerifyStaticTarget(Type targetType, object target)
		{
		}

		internal static void VerifyInstanceTarget<TTArget>(object target)
		{
		}

		private static void VerifyTarget(Type targetType, object target, bool @static)
		{
		}

		private static bool SupportsOptimization(MemberInfo memberInfo)
		{
			return false;
		}

		public static IOptimizedAccessor Prewarm(this FieldInfo fieldInfo)
		{
			return null;
		}

		public static object GetValueOptimized(this FieldInfo fieldInfo, object target)
		{
			return null;
		}

		public static void SetValueOptimized(this FieldInfo fieldInfo, object target, object value)
		{
		}

		public static bool SupportsOptimization(this FieldInfo fieldInfo)
		{
			return false;
		}

		private static IOptimizedAccessor GetFieldAccessor(FieldInfo fieldInfo)
		{
			return null;
		}

		public static IOptimizedAccessor Prewarm(this PropertyInfo propertyInfo)
		{
			return null;
		}

		public static object GetValueOptimized(this PropertyInfo propertyInfo, object target)
		{
			return null;
		}

		public static void SetValueOptimized(this PropertyInfo propertyInfo, object target, object value)
		{
		}

		public static bool SupportsOptimization(this PropertyInfo propertyInfo)
		{
			return false;
		}

		private static IOptimizedAccessor GetPropertyAccessor(PropertyInfo propertyInfo)
		{
			return null;
		}

		public static IOptimizedInvoker Prewarm(this MethodInfo methodInfo)
		{
			return null;
		}

		public static object InvokeOptimized(this MethodInfo methodInfo, object target, params object[] args)
		{
			return null;
		}

		public static object InvokeOptimized(this MethodInfo methodInfo, object target)
		{
			return null;
		}

		public static object InvokeOptimized(this MethodInfo methodInfo, object target, object arg0)
		{
			return null;
		}

		public static object InvokeOptimized(this MethodInfo methodInfo, object target, object arg0, object arg1)
		{
			return null;
		}

		public static object InvokeOptimized(this MethodInfo methodInfo, object target, object arg0, object arg1, object arg2)
		{
			return null;
		}

		public static object InvokeOptimized(this MethodInfo methodInfo, object target, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		public static object InvokeOptimized(this MethodInfo methodInfo, object target, object arg0, object arg1, object arg2, object arg3, object arg4)
		{
			return null;
		}

		public static bool SupportsOptimization(this MethodInfo methodInfo)
		{
			return false;
		}

		private static IOptimizedInvoker GetMethodInvoker(MethodInfo methodInfo)
		{
			return null;
		}
	}
}
