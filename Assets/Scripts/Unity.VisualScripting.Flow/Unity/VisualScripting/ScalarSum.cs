using System.Collections.Generic;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Add")]
	public sealed class ScalarSum : Sum<float>, IDefaultValue<float>
	{
		[DoNotSerialize]
		public float defaultValue => 0f;

		public override float Operation(float a, float b)
		{
			return 0f;
		}

		public override float Operation(IEnumerable<float> values)
		{
			return 0f;
		}

		public ScalarSum()
		{
			((Sum<>)(object)this)._002Ector();
		}
	}
}
