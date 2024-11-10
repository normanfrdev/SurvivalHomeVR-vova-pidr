using System;
using System.Reflection;

namespace Unity.VisualScripting
{
	public class StaticFieldAccessor<TField> : IOptimizedAccessor
	{
		private readonly FieldInfo fieldInfo;

		private Func<TField> getter;

		private Action<TField> setter;

		private Type targetType;

		public StaticFieldAccessor(FieldInfo fieldInfo)
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
