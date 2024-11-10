using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Time")]
	[Obsolete("Use Wait For Seconds or Timer instead.")]
	public sealed class OnTimerElapsed : MachineEventUnit<EmptyEventArgs>
	{
		public new class Data : EventUnit<EmptyEventArgs>.Data
		{
			public float time;

			public bool triggered;

			public Data()
			{
				((EventUnit<>.Data)(object)this)._002Ector();
			}
		}

		protected override string hookName => null;

		[DoNotSerialize]
		[PortLabel("Delay")]
		public ValueInput seconds
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
		[PortLabel("Unscaled")]
		public ValueInput unscaledTime
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

		public override IGraphElementData CreateData()
		{
			return null;
		}

		protected override void Definition()
		{
		}

		public override void StartListening(GraphStack stack)
		{
		}

		protected override bool ShouldTrigger(Flow flow, EmptyEventArgs args)
		{
			return false;
		}

		public OnTimerElapsed()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
