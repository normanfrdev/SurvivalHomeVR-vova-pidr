using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitShortTitle("Set Variable")]
	public abstract class SetVariableUnit : VariableUnit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ControlInput assign
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[DoNotSerialize]
		[PortLabel("New Value")]
		[PortLabelHidden]
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
		[PortLabelHidden]
		public ControlOutput assigned
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[DoNotSerialize]
		[PortLabel("Value")]
		[PortLabelHidden]
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

		protected SetVariableUnit()
		{
		}

		protected SetVariableUnit(string defaultName)
		{
		}

		protected override void Definition()
		{
		}

		protected virtual ControlOutput Assign(Flow flow)
		{
			return null;
		}
	}
}
