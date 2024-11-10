using System.Reflection;

namespace Unity.VisualScripting
{
	public sealed class ReflectionFieldAccessor : IOptimizedAccessor
	{
		private readonly FieldInfo fieldInfo;

		public ReflectionFieldAccessor(FieldInfo fieldInfo)
		{
		}

		public void Compile()
		{
		}

		public object GetValue(object target)
		{
			return null;
		}

		public void SetValue(object target, object value)
		{
		}
	}
}
