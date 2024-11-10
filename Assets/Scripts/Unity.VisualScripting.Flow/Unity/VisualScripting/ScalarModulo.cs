namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Modulo")]
	public sealed class ScalarModulo : Modulo<float>
	{
		protected override float defaultDividend => 0f;

		protected override float defaultDivisor => 0f;

		public override float Operation(float a, float b)
		{
			return 0f;
		}

		public ScalarModulo()
		{
			((Modulo<>)(object)this)._002Ector();
		}
	}
}
