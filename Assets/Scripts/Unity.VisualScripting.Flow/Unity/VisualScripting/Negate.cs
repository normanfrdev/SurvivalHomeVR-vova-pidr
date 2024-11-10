using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitOrder(3)]
	public sealed class Negate : Unit
	{
		[DoNotSerialize]
		[PortLabel("X")]
		public ValueInput input
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
		[PortLabel("~X")]
		public ValueOutput output
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
