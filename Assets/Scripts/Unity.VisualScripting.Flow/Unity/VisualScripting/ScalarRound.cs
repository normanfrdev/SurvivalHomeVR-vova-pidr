namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Round")]
	public sealed class ScalarRound : Round<float, int>
	{
		protected override int Floor(float input)
		{
			return 0;
		}

		protected override int AwayFromZero(float input)
		{
			return 0;
		}

		protected override int Ceiling(float input)
		{
			return 0;
		}

		public ScalarRound()
		{
			((Round<, >)(object)this)._002Ector();
		}
	}
}
