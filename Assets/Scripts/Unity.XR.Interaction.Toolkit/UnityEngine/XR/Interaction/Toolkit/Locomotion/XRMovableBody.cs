using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion
{
	public class XRMovableBody
	{
		public XROrigin xrOrigin
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

		public Transform originTransform => null;

		public IXRBodyPositionEvaluator bodyPositionEvaluator
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

		public IConstrainedXRBodyManipulator constrainedManipulator
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

		public XRMovableBody(XROrigin xrOrigin, IXRBodyPositionEvaluator bodyPositionEvaluator)
		{
		}

		public Vector3 GetBodyGroundLocalPosition()
		{
			return default(Vector3);
		}

		public Vector3 GetBodyGroundWorldPosition()
		{
			return default(Vector3);
		}

		public void LinkConstrainedManipulator(IConstrainedXRBodyManipulator manipulator)
		{
		}

		public void UnlinkConstrainedManipulator()
		{
		}
	}
}
