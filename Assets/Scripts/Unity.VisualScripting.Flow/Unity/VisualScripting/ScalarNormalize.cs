namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Normalize")]
	public sealed class ScalarNormalize : Normalize<float>
	{
		public override float Operation(float input)
		{
			return 0f;
		}

		public ScalarNormalize()
		{
			((Normalize<>)(object)this)._002Ector();
		}
	}
}
