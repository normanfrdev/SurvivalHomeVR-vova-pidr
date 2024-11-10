namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Subtract")]
	public sealed class ScalarSubtract : Subtract<float>
	{
		protected override float defaultMinuend => 0f;

		protected override float defaultSubtrahend => 0f;

		public override float Operation(float a, float b)
		{
			return 0f;
		}

		public ScalarSubtract()
		{
			((Subtract<>)(object)this)._002Ector();
		}
	}
}
