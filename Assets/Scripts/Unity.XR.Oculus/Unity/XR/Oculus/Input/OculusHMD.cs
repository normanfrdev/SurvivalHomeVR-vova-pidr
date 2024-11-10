using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;

namespace Unity.XR.Oculus.Input
{
	[Preserve]
	[InputControlLayout(displayName = "Oculus Headset")]
	public class OculusHMD : XRHMD
	{
		[Preserve]
		[InputControl]
		public ButtonControl userPresence
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

		[Preserve]
		[InputControl(aliases = new string[] { "devicetrackingstate" })]
		public new IntegerControl trackingState
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

		[Preserve]
		[InputControl(aliases = new string[] { "deviceistracked" })]
		public new ButtonControl isTracked
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

		[Preserve]
		[InputControl]
		public new Vector3Control devicePosition
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

		[Preserve]
		[InputControl]
		public new QuaternionControl deviceRotation
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

		[Preserve]
		[InputControl]
		public Vector3Control deviceAngularVelocity
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

		[Preserve]
		[InputControl]
		public Vector3Control deviceAcceleration
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

		[Preserve]
		[InputControl]
		public Vector3Control deviceAngularAcceleration
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

		[Preserve]
		[InputControl]
		public new Vector3Control leftEyePosition
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

		[Preserve]
		[InputControl]
		public new QuaternionControl leftEyeRotation
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

		[Preserve]
		[InputControl]
		public Vector3Control leftEyeAngularVelocity
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

		[Preserve]
		[InputControl]
		public Vector3Control leftEyeAcceleration
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

		[Preserve]
		[InputControl]
		public Vector3Control leftEyeAngularAcceleration
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

		[Preserve]
		[InputControl]
		public new Vector3Control rightEyePosition
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

		[Preserve]
		[InputControl]
		public new QuaternionControl rightEyeRotation
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

		[Preserve]
		[InputControl]
		public Vector3Control rightEyeAngularVelocity
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

		[Preserve]
		[InputControl]
		public Vector3Control rightEyeAcceleration
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

		[Preserve]
		[InputControl]
		public Vector3Control rightEyeAngularAcceleration
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

		[Preserve]
		[InputControl]
		public new Vector3Control centerEyePosition
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

		[Preserve]
		[InputControl]
		public new QuaternionControl centerEyeRotation
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

		[Preserve]
		[InputControl]
		public Vector3Control centerEyeAngularVelocity
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

		[Preserve]
		[InputControl]
		public Vector3Control centerEyeAcceleration
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

		[Preserve]
		[InputControl]
		public Vector3Control centerEyeAngularAcceleration
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

		protected override void FinishSetup()
		{
		}
	}
}
