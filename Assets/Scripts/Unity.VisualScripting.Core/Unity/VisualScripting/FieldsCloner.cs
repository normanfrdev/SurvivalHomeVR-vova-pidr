using System.Reflection;

namespace Unity.VisualScripting
{
	public sealed class FieldsCloner : ReflectedCloner
	{
		protected override bool IncludeField(FieldInfo field)
		{
			return false;
		}

		protected override bool IncludeProperty(PropertyInfo property)
		{
			return false;
		}
	}
}
