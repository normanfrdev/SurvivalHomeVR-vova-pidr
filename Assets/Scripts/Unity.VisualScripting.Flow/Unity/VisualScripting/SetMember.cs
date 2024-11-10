using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class SetMember : MemberUnit
	{
		[Serialize]
		[InspectableIf("supportsChaining")]
		public bool chainable
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
		public bool supportsChaining => false;

		[DoNotSerialize]
		[MemberFilter(Fields = true, Properties = true, ReadOnly = false)]
		public Member setter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DoNotSerialize]
		[PortLabelHidden]
		public ControlInput assign
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
		[PortLabel("Value")]
		[PortLabelHidden]
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
		[PortLabel("Value")]
		[PortLabelHidden]
		public ValueOutput output
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
		[PortLabel("Target")]
		[PortLabelHidden]
		public ValueOutput targetOutput
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
		public ControlOutput assigned
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

		public SetMember()
		{
		}

		public SetMember(Member member)
		{
		}

		protected override void Definition()
		{
		}

		protected override bool IsMemberValid(Member member)
		{
			return false;
		}

		private object GetAndChainTarget(Flow flow)
		{
			return null;
		}

		private ControlOutput Assign(Flow flow)
		{
			return null;
		}

		public override AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}
	}
}
