using System.Collections.Generic;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Maximum")]
	public sealed class ScalarMaximum : Maximum<float>
	{
		public override float Operation(float a, float b)
		{
			return 0f;
		}

		public override float Operation(IEnumerable<float> values)
		{
			return 0f;
		}

		public ScalarMaximum()
		{
			((Maximum<>)(object)this)._002Ector();
		}
	}
}
