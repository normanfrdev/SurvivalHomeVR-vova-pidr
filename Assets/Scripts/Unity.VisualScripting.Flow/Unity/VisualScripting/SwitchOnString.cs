using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitTitle("Switch On String")]
	[UnitShortTitle("Switch")]
	[UnitSubtitle("On String")]
	[UnitOrder(4)]
	public class SwitchOnString : SwitchUnit<string>
	{
		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable("Ignore Case")]
		[InspectorToggleLeft]
		public bool ignoreCase
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

		protected override bool Matches(string a, string b)
		{
			return false;
		}

		public SwitchOnString()
		{
			((SwitchUnit<>)(object)this)._002Ector();
		}
	}
}
