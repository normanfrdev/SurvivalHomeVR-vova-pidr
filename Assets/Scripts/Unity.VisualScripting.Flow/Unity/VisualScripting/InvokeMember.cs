using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class InvokeMember : MemberUnit
	{
		private bool useExpandedParameters;

		[DoNotSerialize]
		private int parameterCount;

		[Serialize]
		private List<string> parameterNames;

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
		[MemberFilter(Methods = true, Constructors = true)]
		public Member invocation
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
		public ControlInput enter
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
		public Dictionary<int, ValueInput> inputParameters
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

		[DoNotSerialize]
		public Dictionary<int, ValueOutput> outputParameters
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
		public ControlOutput exit
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

		public InvokeMember()
		{
		}

		public InvokeMember(Member member)
		{
		}

		public override bool HandleDependencies()
		{
			return false;
		}

		protected override void Definition()
		{
		}

		private void PostDeserializeRemapParameterNames()
		{
		}

		protected override bool IsMemberValid(Member member)
		{
			return false;
		}

		private object Invoke(object target, Flow flow)
		{
			return null;
		}

		private object GetAndChainTarget(Flow flow)
		{
			return null;
		}

		private object Result(Flow flow)
		{
			return null;
		}

		private ControlOutput Enter(Flow flow)
		{
			return null;
		}

		public override AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}
	}
}
