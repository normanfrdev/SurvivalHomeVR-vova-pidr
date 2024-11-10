namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitOrder(9)]
	public sealed class Less : BinaryComparisonUnit
	{
		[PortLabel("A < B")]
		public override ValueOutput comparison => null;

		protected override bool NumericComparison(float a, float b)
		{
			return false;
		}

		protected override bool GenericComparison(object a, object b)
		{
			return false;
		}
	}
}
