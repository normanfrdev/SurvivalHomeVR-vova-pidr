using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class GetVariable : UnifiedVariableUnit
	{
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

		[DoNotSerialize]
		public ValueInput fallback
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
		[InspectorLabel("Fallback")]
		public bool specifyFallback
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

		protected override void Definition()
		{
		}

		private bool IsDefined(Flow flow)
		{
			return false;
		}

		private object Get(Flow flow)
		{
			return null;
		}
	}
}
