using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Root")]
	[UnitOrder(106)]
	public sealed class ScalarRoot : Unit
	{
		[DoNotSerialize]
		[PortLabel("x")]
		public ValueInput radicand
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
		[PortLabel("n")]
		public ValueInput degree
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
		[PortLabel("ⁿ√x")]
		public ValueOutput root
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

		public float Root(Flow flow)
		{
			return 0f;
		}
	}
}
