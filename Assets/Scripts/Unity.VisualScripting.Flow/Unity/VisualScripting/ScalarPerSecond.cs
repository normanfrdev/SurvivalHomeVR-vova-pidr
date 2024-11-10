namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Per Second")]
	public sealed class ScalarPerSecond : PerSecond<float>
	{
		public override float Operation(float input)
		{
			return 0f;
		}

		public ScalarPerSecond()
		{
			((PerSecond<>)(object)this)._002Ector();
		}
	}
}
