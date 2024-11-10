using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(displayName = "Ambient Temperature")]
	public class AmbientTemperatureSensor : Sensor
	{
		[InputControl(displayName = "Ambient Temperature", noisy = true)]
		public AxisControl ambientTemperature
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

		public static AmbientTemperatureSensor current
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
