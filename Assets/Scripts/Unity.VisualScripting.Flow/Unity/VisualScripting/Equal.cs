namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitOrder(5)]
	public sealed class Equal : BinaryComparisonUnit
	{
		protected override string outputKey => null;

		[DoNotSerialize]
		[PortLabel("A = B")]
		[PortKey("equal")]
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
