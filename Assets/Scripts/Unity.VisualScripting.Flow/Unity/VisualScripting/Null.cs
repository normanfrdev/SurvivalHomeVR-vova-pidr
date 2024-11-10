using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Nulls")]
	public sealed class Null : Unit
	{
		[DoNotSerialize]
		public ValueOutput @null
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
