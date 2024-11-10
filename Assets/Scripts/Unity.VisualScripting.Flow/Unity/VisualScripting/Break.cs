using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitTitle("Break Loop")]
	[UnitCategory("Control")]
	[UnitOrder(13)]
	public class Break : Unit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ControlInput enter
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

		public ControlOutput Operation(Flow flow)
		{
			return null;
		}
	}
}
