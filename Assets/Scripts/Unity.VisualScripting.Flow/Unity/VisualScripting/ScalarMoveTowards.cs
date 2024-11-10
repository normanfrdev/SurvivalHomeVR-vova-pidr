namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Move Towards")]
	public sealed class ScalarMoveTowards : MoveTowards<float>
	{
		protected override float defaultCurrent => 0f;

		protected override float defaultTarget => 0f;

		public override float Operation(float current, float target, float maxDelta)
		{
			return 0f;
		}

		public ScalarMoveTowards()
		{
			((MoveTowards<>)(object)this)._002Ector();
		}
	}
}
