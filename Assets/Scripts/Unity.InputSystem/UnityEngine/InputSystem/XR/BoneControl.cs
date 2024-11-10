using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR
{
	public class BoneControl : InputControl<Bone>
	{
		[InputControl(offset = 0u, displayName = "parentBoneIndex")]
		public IntegerControl parentBoneIndex
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

		[InputControl(offset = 4u, displayName = "Position")]
		public Vector3Control position
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

		[InputControl(offset = 16u, displayName = "Rotation")]
		public QuaternionControl rotation
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

		public unsafe override Bone ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Bone);
		}

		public unsafe override void WriteValueIntoState(Bone value, void* statePtr)
		{
		}

		public BoneControl()
		{
			((InputControl<>)(object)this)._002Ector();
		}
	}
}
