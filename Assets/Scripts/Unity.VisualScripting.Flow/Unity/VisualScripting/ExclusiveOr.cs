using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitOrder(2)]
	public sealed class ExclusiveOr : Unit
	{
		[DoNotSerialize]
		public ValueInput a
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DoNotSerialize]
		public ValueInput b
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DoNotSerialize]
		[PortLabel("A ⊕ B")]
		public ValueOutput result
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected override void Definition()
		{
		}

		public bool Operation(Flow flow)
		{
			return false;
		}
	}
}
