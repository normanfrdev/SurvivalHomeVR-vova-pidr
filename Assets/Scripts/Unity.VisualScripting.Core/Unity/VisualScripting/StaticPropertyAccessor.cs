using System;
using System.Reflection;

namespace Unity.VisualScripting
{
	public class StaticPropertyAccessor<TProperty> : IOptimizedAccessor
	{
		private readonly PropertyInfo propertyInfo;

		private Func<TProperty> getter;

		private Action<TProperty> setter;

		private Type targetType;

		public StaticPropertyAccessor(PropertyInfo propertyInfo)
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
