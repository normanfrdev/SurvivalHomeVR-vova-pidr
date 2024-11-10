using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(displayName = "Magnetic Field")]
	public class MagneticFieldSensor : Sensor
	{
		[InputControl(displayName = "Magnetic Field", noisy = true)]
		public Vector3Control magneticField
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

		public static MagneticFieldSensor current
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
