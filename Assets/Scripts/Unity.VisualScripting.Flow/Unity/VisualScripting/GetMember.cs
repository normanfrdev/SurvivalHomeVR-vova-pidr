using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class GetMember : MemberUnit
	{
		[DoNotSerialize]
		[MemberFilter(Fields = true, Properties = true, WriteOnly = false)]
		public Member getter
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
		public ValueOutput value
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

		public GetMember()
		{
		}

		public GetMember(Member member)
		{
		}

		protected override void Definition()
		{
		}

		protected override bool IsMemberValid(Member member)
		{
			return false;
		}

		private object Value(Flow flow)
		{
			return null;
		}

		public override AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}
	}
}
