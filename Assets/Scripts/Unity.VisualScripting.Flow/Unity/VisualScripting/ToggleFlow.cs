using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitOrder(18)]
	[UnitFooterPorts(ControlInputs = true, ControlOutputs = true)]
	public sealed class ToggleFlow : Unit, IGraphElementWithData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public class Data : IGraphElementData
		{
			public bool isOn;
		}

		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable("Start On")]
		[InspectorToggleLeft]
		public bool startOn
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

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

		[DoNotSerialize]
		[PortLabel("On")]
		public ControlInput turnOn
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
		[PortLabel("Off")]
		public ControlInput turnOff
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
		public ControlInput toggle
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
		[PortLabel("On")]
		public ControlOutput exitOn
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
		[PortLabel("Off")]
		public ControlOutput exitOff
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
		public ControlOutput turnedOn
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
		public ControlOutput turnedOff
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
		public ValueOutput isOn
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

		public IGraphElementData CreateData()
		{
			return null;
		}

		private bool IsOn(Flow flow)
		{
			return false;
		}

		private ControlOutput Enter(Flow flow)
		{
			return null;
		}

		private ControlOutput TurnOn(Flow flow)
		{
			return null;
		}

		private ControlOutput TurnOff(Flow flow)
		{
			return null;
		}

		private ControlOutput Toggle(Flow flow)
		{
			return null;
		}
	}
}
