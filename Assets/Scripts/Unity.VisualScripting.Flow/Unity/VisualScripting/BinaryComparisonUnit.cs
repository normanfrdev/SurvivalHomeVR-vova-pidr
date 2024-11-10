using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	public abstract class BinaryComparisonUnit : Unit
	{
		[DoNotSerialize]
		public ValueInput a
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
		public ValueInput b
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
		public virtual ValueOutput comparison
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
		[Inspectable]
		[InspectorToggleLeft]
		public bool numeric
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

		protected virtual string outputKey => null;

		protected override void Definition()
		{
		}

		private bool NumericComparison(Flow flow)
		{
			return false;
		}

		private bool GenericComparison(Flow flow)
		{
			return false;
		}

		protected abstract bool NumericComparison(float a, float b);

		protected abstract bool GenericComparison(object a, object b);
	}
}
