using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(501)]
	public abstract class Lerp<T> : Unit
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
		public ValueInput t
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
		public ValueOutput interpolation
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
		protected virtual T defaultA => default(T);

		[DoNotSerialize]
		protected virtual T defaultB => default(T);

		protected override void Definition()
		{
		}

		private T Operation(Flow flow)
		{
			return default(T);
		}

		public abstract T Operation(T a, T b, float t);
	}
}
