using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitTitle("Select On String")]
	[UnitShortTitle("Select")]
	[UnitSubtitle("On String")]
	[UnitOrder(7)]
	public class SelectOnString : SelectUnit<string>
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

		public SelectOnString()
		{
			((SelectUnit<>)(object)this)._002Ector();
		}
	}
}
