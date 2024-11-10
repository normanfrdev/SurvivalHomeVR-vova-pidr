using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections")]
	public sealed class LastItem : Unit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueInput collection
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
		[PortLabelHidden]
		public ValueOutput lastItem
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

		public object First(Flow flow)
		{
			return null;
		}
	}
}
