using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion
{
	public abstract class ScriptableConstrainedBodyManipulator : ScriptableObject, IConstrainedXRBodyManipulator
	{
		public XRMovableBody linkedBody
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

		public abstract CollisionFlags lastCollisionFlags { get; }

		public abstract bool isGrounded { get; }

		public virtual void OnLinkedToBody(XRMovableBody body)
		{
		}

		public virtual void OnUnlinkedFromBody()
		{
		}

		public abstract CollisionFlags MoveBody(Vector3 motion);
	}
}
