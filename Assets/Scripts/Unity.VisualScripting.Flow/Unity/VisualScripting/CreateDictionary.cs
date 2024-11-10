using System.Collections;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Collections/Dictionaries")]
	[UnitOrder(-1)]
	[TypeIcon(typeof(IDictionary))]
	[RenamedFrom("Bolt.CreateDitionary")]
	public sealed class CreateDictionary : Unit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput dictionary
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

		public IDictionary Create(Flow flow)
		{
			return null;
		}
	}
}
