using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitShortTitle("Equal")]
	[UnitSubtitle("(Approximately)")]
	[UnitOrder(7)]
	[Obsolete("Use the Equal node with Numeric enabled instead.")]
	public sealed class ApproximatelyEqual : Unit
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
		[PortLabel("A ≈ B")]
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

		protected override void Definition()
		{
		}

		public bool Comparison(Flow flow)
		{
			return false;
		}
	}
}
