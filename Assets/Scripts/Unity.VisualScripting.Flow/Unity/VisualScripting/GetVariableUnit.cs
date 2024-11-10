using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitShortTitle("Get Variable")]
	public abstract class GetVariableUnit : VariableUnit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput value
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

		protected GetVariableUnit()
		{
		}

		protected GetVariableUnit(string defaultName)
		{
		}

		protected override void Definition()
		{
		}

		protected virtual bool IsDefined(Flow flow)
		{
			return false;
		}

		protected virtual object Get(Flow flow)
		{
			return null;
		}
	}
}
