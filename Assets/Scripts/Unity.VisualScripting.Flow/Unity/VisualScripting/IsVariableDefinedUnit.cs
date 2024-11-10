using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitShortTitle("Is Variable Defined")]
	public abstract class IsVariableDefinedUnit : VariableUnit
	{
		[DoNotSerialize]
		[PortLabel("Defined")]
		[PortLabelHidden]
		public new ValueOutput isDefined
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

		protected IsVariableDefinedUnit()
		{
		}

		protected IsVariableDefinedUnit(string defaultName)
		{
		}

		protected override void Definition()
		{
		}

		protected virtual bool IsDefined(Flow flow)
		{
			return false;
		}
	}
}
