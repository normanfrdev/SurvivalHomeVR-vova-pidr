using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion
{
	[CreateAssetMenu(fileName = "CharacterControllerBodyManipulator", menuName = "XR/Locomotion/Character Controller Body Manipulator")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.CharacterControllerBodyManipulator.html")]
	public class CharacterControllerBodyManipulator : ScriptableConstrainedBodyManipulator
	{
		public override CollisionFlags lastCollisionFlags => default(CollisionFlags);

		public override bool isGrounded => false;

		public CharacterController characterController
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

		public override void OnLinkedToBody(XRMovableBody body)
		{
		}

		public override void OnUnlinkedFromBody()
		{
		}

		public override CollisionFlags MoveBody(Vector3 motion)
		{
			return default(CollisionFlags);
		}
	}
}
