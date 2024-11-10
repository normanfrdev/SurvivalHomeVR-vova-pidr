using System.Collections.Generic;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Average")]
	public sealed class ScalarAverage : Average<float>
	{
		public override float Operation(float a, float b)
		{
			return 0f;
		}

		public override float Operation(IEnumerable<float> values)
		{
			return 0f;
		}

		public ScalarAverage()
		{
			((Average<>)(object)this)._002Ector();
		}
	}
}
