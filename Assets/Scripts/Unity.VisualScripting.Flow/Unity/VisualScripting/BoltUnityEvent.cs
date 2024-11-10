using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Events")]
	[UnitTitle("UnityEvent")]
	[UnitOrder(2)]
	[DisplayName("Visual Scripting Unity Event")]
	public sealed class BoltUnityEvent : MachineEventUnit<string>
	{
		protected override string hookName => null;

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueInput name
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

		protected override bool ShouldTrigger(Flow flow, string name)
		{
			return false;
		}

		public BoltUnityEvent()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
