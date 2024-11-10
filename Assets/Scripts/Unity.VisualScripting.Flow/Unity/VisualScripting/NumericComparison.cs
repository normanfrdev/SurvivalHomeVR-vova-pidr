using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitTitle("Numeric Comparison")]
	[UnitSurtitle("Numeric")]
	[UnitShortTitle("Comparison")]
	[UnitOrder(99)]
	[Obsolete("Use the Comparison node with Numeric enabled instead.")]
	public sealed class NumericComparison : Unit
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
		[PortLabel("A < B")]
		public ValueOutput aLessThanB
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
		[PortLabel("A ≤ B")]
		public ValueOutput aLessThanOrEqualToB
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
		[PortLabel("A = B")]
		public ValueOutput aEqualToB
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
		[PortLabel("A ≥ B")]
		public ValueOutput aGreaterThanOrEqualToB
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
		[PortLabel("A > B")]
		public ValueOutput aGreatherThanB
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

		private bool Less(Flow flow)
		{
			return false;
		}

		private bool LessOrEqual(Flow flow)
		{
			return false;
		}

		private bool Equal(Flow flow)
		{
			return false;
		}

		private bool GreaterOrEqual(Flow flow)
		{
			return false;
		}

		private bool Greater(Flow flow)
		{
			return false;
		}
	}
}
