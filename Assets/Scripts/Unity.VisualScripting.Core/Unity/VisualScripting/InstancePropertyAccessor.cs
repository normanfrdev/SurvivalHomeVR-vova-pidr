using System;
using System.Reflection;

namespace Unity.VisualScripting
{
	public class InstancePropertyAccessor<TTarget, TProperty> : IOptimizedAccessor
	{
		private readonly PropertyInfo propertyInfo;

		private Func<TTarget, TProperty> getter;

		private Action<TTarget, TProperty> setter;

		public InstancePropertyAccessor(PropertyInfo propertyInfo)
		{
		}

		public void Compile()
		{
		}

		public object GetValue(object target)
		{
			return null;
		}

		private object GetValueUnsafe(object target)
		{
			return null;
		}

		public void SetValue(object target, object value)
		{
		}

		private void SetValueUnsafe(object target, object value)
		{
		}
	}
}
