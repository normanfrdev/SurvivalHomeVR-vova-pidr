namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Absolute")]
	public sealed class ScalarAbsolute : Absolute<float>
	{
		protected override float Operation(float input)
		{
			return 0f;
		}

		public ScalarAbsolute()
		{
			((Absolute<>)(object)this)._002Ector();
		}
	}
}
