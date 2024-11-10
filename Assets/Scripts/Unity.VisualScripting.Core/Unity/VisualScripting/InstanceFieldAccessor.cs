using System;
using System.Reflection;

namespace Unity.VisualScripting
{
	public class InstanceFieldAccessor<TTarget, TField> : IOptimizedAccessor
	{
		private readonly FieldInfo fieldInfo;

		private Func<TTarget, TField> getter;

		private Action<TTarget, TField> setter;

		public InstanceFieldAccessor(FieldInfo fieldInfo)
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
