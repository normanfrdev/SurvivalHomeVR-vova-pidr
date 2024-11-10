using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitTitle("Has Variable")]
	public sealed class IsVariableDefined : UnifiedVariableUnit
	{
		[DoNotSerialize]
		[PortLabel("Defined")]
		[PortLabelHidden]
		[PortKey("isDefined")]
		public ValueOutput isVariableDefined
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

		private bool IsDefined(Flow flow)
		{
			return false;
		}
	}
}
