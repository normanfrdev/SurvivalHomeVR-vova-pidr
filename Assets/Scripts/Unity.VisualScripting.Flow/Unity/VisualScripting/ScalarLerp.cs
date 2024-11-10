namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Lerp")]
	public sealed class ScalarLerp : Lerp<float>
	{
		protected override float defaultA => 0f;

		protected override float defaultB => 0f;

		public override float Operation(float a, float b, float t)
		{
			return 0f;
		}

		public ScalarLerp()
		{
			((Lerp<>)(object)this)._002Ector();
		}
	}
}
