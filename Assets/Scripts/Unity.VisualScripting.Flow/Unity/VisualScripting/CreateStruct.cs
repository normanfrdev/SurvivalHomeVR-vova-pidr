using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	public sealed class CreateStruct : Unit
	{
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

		public override bool canDefine => false;

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
		public CreateStruct()
		{
		}

		public CreateStruct(Type type)
		{
		}

		protected override void Definition()
		{
		}

		private ControlOutput Enter(Flow flow)
		{
			return null;
		}

		private object Create(Flow flow)
		{
			return null;
		}
	}
}
