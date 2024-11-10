namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Multiply")]
	public sealed class ScalarMultiply : Multiply<float>
	{
		protected override float defaultB => 0f;

		public override float Operation(float a, float b)
		{
			return 0f;
		}

		public ScalarMultiply()
		{
			((Multiply<>)(object)this)._002Ector();
		}
	}
}
