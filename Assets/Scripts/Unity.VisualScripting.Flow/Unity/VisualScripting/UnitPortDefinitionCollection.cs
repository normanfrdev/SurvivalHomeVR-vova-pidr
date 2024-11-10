using System.Collections.ObjectModel;

namespace Unity.VisualScripting
{
	public sealed class UnitPortDefinitionCollection<T> : Collection<T> where T : IUnitPortDefinition
	{
		public UnitPortDefinitionCollection()
		{
			((Collection<T>)(object)this)._002Ector();
		}
	}
}
