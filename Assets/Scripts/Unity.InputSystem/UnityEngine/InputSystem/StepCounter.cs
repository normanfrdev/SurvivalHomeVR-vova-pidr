using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem
{
	[InputControlLayout(displayName = "Step Counter")]
	public class StepCounter : Sensor
	{
		[InputControl(displayName = "Step Counter", noisy = true)]
		public IntegerControl stepCounter
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

		public static StepCounter current
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
