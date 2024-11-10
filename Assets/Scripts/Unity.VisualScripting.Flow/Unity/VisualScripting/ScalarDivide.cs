namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Divide")]
	public sealed class ScalarDivide : Divide<float>
	{
		protected override float defaultDividend => 0f;

		protected override float defaultDivisor => 0f;

		public override float Operation(float a, float b)
		{
			return 0f;
		}

		public ScalarDivide()
		{
			((Divide<>)(object)this)._002Ector();
		}
	}
}
