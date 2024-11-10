using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR
{
	[InputControlLayout(isGenericTypeOfDevice = true, displayName = "XR HMD", canRunInBackground = true)]
	public class XRHMD : TrackedDevice
	{
		[InputControl(noisy = true)]
		public Vector3Control leftEyePosition
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

		[InputControl(noisy = true)]
		public QuaternionControl leftEyeRotation
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

		[InputControl(noisy = true)]
		public Vector3Control rightEyePosition
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

		[InputControl(noisy = true)]
		public QuaternionControl rightEyeRotation
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

		[InputControl(noisy = true)]
		public Vector3Control centerEyePosition
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

		[InputControl(noisy = true)]
		public QuaternionControl centerEyeRotation
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

		protected override void FinishSetup()
		{
		}
	}
}
