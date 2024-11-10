using System.Collections.Generic;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Minimum")]
	public sealed class ScalarMinimum : Minimum<float>
	{
		public override float Operation(float a, float b)
		{
			return 0f;
		}

		public override float Operation(IEnumerable<float> values)
		{
			return 0f;
		}

		public ScalarMinimum()
		{
			((Minimum<>)(object)this)._002Ector();
		}
	}
}
