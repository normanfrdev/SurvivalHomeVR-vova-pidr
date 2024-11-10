using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitTitle("Equality Comparison")]
	[UnitSurtitle("Equality")]
	[UnitShortTitle("Comparison")]
	[UnitOrder(4)]
	[Obsolete("Use the Comparison node instead.")]
	public sealed class EqualityComparison : Unit
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
		[PortLabel("A = B")]
		public ValueOutput equal
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
		[PortLabel("A ≠ B")]
		public ValueOutput notEqual
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

		private bool Equal(Flow flow)
		{
			return false;
		}

		private bool NotEqual(Flow flow)
		{
			return false;
		}
	}
}
