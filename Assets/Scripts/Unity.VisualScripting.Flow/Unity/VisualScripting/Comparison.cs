using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Logic")]
	[UnitTitle("Comparison")]
	[UnitShortTitle("Comparison")]
	[UnitOrder(99)]
	public sealed class Comparison : Unit
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

		[Serialize]
		[Inspectable]
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

		[DoNotSerialize]
		[PortLabel("A < B")]
		public ValueOutput aLessThanB
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
		[PortLabel("A ≤ B")]
		public ValueOutput aLessThanOrEqualToB
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
		[PortLabel("A = B")]
		public ValueOutput aEqualToB
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
		[PortLabel("A ≠ B")]
		public ValueOutput aNotEqualToB
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
		[PortLabel("A ≥ B")]
		public ValueOutput aGreaterThanOrEqualToB
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
		[PortLabel("A > B")]
		public ValueOutput aGreatherThanB
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

		private bool NumericLess(float a, float b)
		{
			return false;
		}

		private bool NumericLessOrEqual(float a, float b)
		{
			return false;
		}

		private bool NumericEqual(float a, float b)
		{
			return false;
		}

		private bool NumericNotEqual(float a, float b)
		{
			return false;
		}

		private bool NumericGreaterOrEqual(float a, float b)
		{
			return false;
		}

		private bool NumericGreater(float a, float b)
		{
			return false;
		}

		private bool GenericLess(object a, object b)
		{
			return false;
		}

		private bool GenericLessOrEqual(object a, object b)
		{
			return false;
		}

		private bool GenericEqual(object a, object b)
		{
			return false;
		}

		private bool GenericNotEqual(object a, object b)
		{
			return false;
		}

		private bool GenericGreaterOrEqual(object a, object b)
		{
			return false;
		}

		private bool GenericGreater(object a, object b)
		{
			return false;
		}
	}
}
