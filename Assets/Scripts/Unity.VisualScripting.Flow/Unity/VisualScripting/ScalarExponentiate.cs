using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Scalar")]
	[UnitTitle("Exponentiate")]
	[UnitOrder(105)]
	public sealed class ScalarExponentiate : Unit
	{
		[DoNotSerialize]
		[PortLabel("x")]
		public ValueInput @base
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
		public ValueInput exponent
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
		[PortLabel("xⁿ")]
		public ValueOutput power
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

		public float Exponentiate(Flow flow)
		{
			return 0f;
		}
	}
}
