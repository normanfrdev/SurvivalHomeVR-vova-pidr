using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR
{
	public class EyesControl : InputControl<Eyes>
	{
		[InputControl(offset = 0u, displayName = "LeftEyePosition")]
		public Vector3Control leftEyePosition
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[InputControl(offset = 12u, displayName = "LeftEyeRotation")]
		public QuaternionControl leftEyeRotation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[InputControl(offset = 28u, displayName = "RightEyePosition")]
		public Vector3Control rightEyePosition
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[InputControl(offset = 40u, displayName = "RightEyeRotation")]
		public QuaternionControl rightEyeRotation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[InputControl(offset = 56u, displayName = "FixationPoint")]
		public Vector3Control fixationPoint
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[InputControl(offset = 68u, displayName = "LeftEyeOpenAmount")]
		public AxisControl leftEyeOpenAmount
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[InputControl(offset = 72u, displayName = "RightEyeOpenAmount")]
		public AxisControl rightEyeOpenAmount
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void FinishSetup()
		{
		}

		public unsafe override Eyes ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Eyes);
		}

		public unsafe override void WriteValueIntoState(Eyes value, void* statePtr)
		{
		}

		public EyesControl()
		{
			((InputControl<>)(object)this)._002Ector();
		}
	}
}
