using System.Collections;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Lists")]
	[UnitOrder(-1)]
	[TypeIcon(typeof(IList))]
	public sealed class CreateList : MultiInputUnit<object>
	{
		[DoNotSerialize]
		protected override int minInputCount => 0;

		[InspectorLabel("Elements")]
		[UnitHeaderInspectable("Elements")]
		[Inspectable]
		public override int inputCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput list
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

		public IList Create(Flow flow)
		{
			return null;
		}

		public CreateList()
		{
			((MultiInputUnit<>)(object)this)._002Ector();
		}
	}
}
