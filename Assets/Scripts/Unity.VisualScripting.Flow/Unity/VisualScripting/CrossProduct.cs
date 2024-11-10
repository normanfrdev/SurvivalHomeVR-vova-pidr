using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitOrder(405)]
	[TypeIcon(typeof(Multiply<>))]
	public abstract class CrossProduct<T> : Unit
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
		[PortLabel("A × B")]
		public ValueOutput crossProduct
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

		private T Operation(Flow flow)
		{
			return default(T);
		}

		public abstract T Operation(T a, T b);
	}
}
