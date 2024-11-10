using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[TypeIcon(typeof(StateGraph))]
	[UnitCategory("Nesting")]
	public sealed class StateUnit : NesterUnit<StateGraph, StateGraphAsset>
	{
		[DoNotSerialize]
		public ControlInput start
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
		public ControlInput stop
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
		public ControlOutput started
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
		public ControlOutput stopped
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

		public StateUnit()
		{
			((NesterUnit<TGraph, TMacro>)(object)this)._002Ector();
		}

		public StateUnit(StateGraphAsset macro)
		{
			((NesterUnit<TGraph, TMacro>)(object)this)._002Ector();
		}

		public static StateUnit WithStart()
		{
			return null;
		}

		protected override void Definition()
		{
		}

		private ControlOutput Start(Flow flow)
		{
			return null;
		}

		private ControlOutput Stop(Flow flow)
		{
			return null;
		}

		public override StateGraph DefaultGraph()
		{
			return null;
		}
	}
}
