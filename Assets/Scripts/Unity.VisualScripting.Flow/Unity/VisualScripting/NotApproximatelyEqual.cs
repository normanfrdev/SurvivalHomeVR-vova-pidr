using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitShortTitle("Not Equal")]
	[UnitSubtitle("(Approximately)")]
	[UnitOrder(8)]
	[Obsolete("Use the Not Equal node with Numeric enabled instead.")]
	public sealed class NotApproximatelyEqual : Unit
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
		[PortLabel("A ≉ B")]
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

		public bool Comparison(Flow flow)
		{
			return false;
		}
	}
}
