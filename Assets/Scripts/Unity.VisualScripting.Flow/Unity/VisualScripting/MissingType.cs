using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	[UnitTitle("Node script is missing!")]
	[UnitShortTitle("Missing Script!")]
	public sealed class MissingType : Unit
	{
		[Serialize]
		public string formerType
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

		[Serialize]
		public string formerValue
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
	}
}
