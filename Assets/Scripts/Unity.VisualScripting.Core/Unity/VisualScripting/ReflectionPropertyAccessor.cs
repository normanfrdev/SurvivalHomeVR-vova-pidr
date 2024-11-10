using System.Reflection;

namespace Unity.VisualScripting
{
	public sealed class ReflectionPropertyAccessor : IOptimizedAccessor
	{
		private readonly PropertyInfo propertyInfo;

		public ReflectionPropertyAccessor(PropertyInfo propertyInfo)
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
