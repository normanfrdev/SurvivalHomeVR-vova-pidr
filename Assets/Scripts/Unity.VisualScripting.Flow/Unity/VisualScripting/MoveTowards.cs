using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(502)]
	public abstract class MoveTowards<T> : Unit
	{
		[DoNotSerialize]
		public ValueInput current
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
		public ValueInput target
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
		public ValueInput maxDelta
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

		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable("Per Second")]
		[InspectorToggleLeft]
		public bool perSecond
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
		protected virtual T defaultCurrent => default(T);

		[DoNotSerialize]
		protected virtual T defaultTarget => default(T);

		protected override void Definition()
		{
		}

		private T Operation(Flow flow)
		{
			return default(T);
		}

		public abstract T Operation(T current, T target, float maxDelta);
	}
}
