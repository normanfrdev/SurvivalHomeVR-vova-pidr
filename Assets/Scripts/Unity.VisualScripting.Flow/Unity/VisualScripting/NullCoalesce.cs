using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Nulls")]
	[TypeIcon(typeof(Null))]
	public sealed class NullCoalesce : Unit
	{
		[DoNotSerialize]
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
		public ValueInput fallback
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
		public ValueOutput result
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

		public object Coalesce(Flow flow)
		{
			return null;
		}
	}
}
