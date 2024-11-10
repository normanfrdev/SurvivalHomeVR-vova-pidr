using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	public sealed class Literal : Unit
	{
		[SerializeAs("value")]
		private object _value;

		public override bool canDefine => false;

		[Serialize]
		public Type type
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		[DoNotSerialize]
		public object value
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

		[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
		public Literal()
		{
		}

		public Literal(Type type)
		{
		}

		public Literal(Type type, object value)
		{
		}

		protected override void Definition()
		{
		}

		public override AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}
	}
}
