using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(displayName = "Proximity")]
	public class ProximitySensor : Sensor
	{
		[InputControl(displayName = "Distance", noisy = true)]
		public AxisControl distance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public static ProximitySensor current
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

		public override void MakeCurrent()
		{
		}

		protected override void OnRemoved()
		{
		}

		protected override void FinishSetup()
		{
		}
	}
}
