using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Control")]
	[UnitOrder(17)]
	[UnitFooterPorts(ControlOutputs = true)]
	public sealed class TryCatch : Unit
	{
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
		public ControlOutput @try
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
		public ControlOutput @catch
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
		public ControlOutput @finally
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
		public ValueOutput exception
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
		[UnitHeaderInspectable]
		[TypeFilter(new Type[] { typeof(Exception) }, Matching = TypesMatching.AssignableToAll)]
		[TypeSet(TypeSet.SettingsAssembliesTypes)]
		public Type exceptionType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override bool canDefine => false;

		protected override void Definition()
		{
		}

		public ControlOutput Enter(Flow flow)
		{
			return null;
		}
	}
}
