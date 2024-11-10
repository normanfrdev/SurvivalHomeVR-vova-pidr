namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitOrder(6)]
	public sealed class NotEqual : BinaryComparisonUnit
	{
		protected override string outputKey => null;

		[DoNotSerialize]
		[PortLabel("A ≠ B")]
		[PortKey("notEqual")]
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
