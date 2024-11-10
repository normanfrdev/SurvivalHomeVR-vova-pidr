using System.Collections.Generic;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Generic")]
	[UnitTitle("Add")]
	public sealed class GenericSum : Sum<object>
	{
		public override object Operation(object a, object b)
		{
			return null;
		}

		public override object Operation(IEnumerable<object> values)
		{
			return null;
		}

		public GenericSum()
		{
			((Sum<>)(object)this)._002Ector();
		}
	}
}
