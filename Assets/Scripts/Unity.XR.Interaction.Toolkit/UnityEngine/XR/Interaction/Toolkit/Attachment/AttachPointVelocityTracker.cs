using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Attachment
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit.Interaction")]
	public class AttachPointVelocityTracker : IAttachPointVelocityTracker, IAttachPointVelocityProvider
	{
		private float m_DeltaTimeStart;

		private const int k_VelocityUpdateInterval = 6;

		private int m_FrameOn;

		private readonly Vector3[] m_VelocityPositionsCache;

		private readonly Vector3[] m_VelocityNormalsCache;

		private Vector3 m_VelocityPositionsSum;

		private Vector3 m_VelocityNormalsSum;

		private Vector3 m_AttachPointVelocity;

		private Vector3 m_AttachPointAngularVelocity;

		public void UpdateAttachPointVelocityData(Transform attachTransform)
		{
		}

		public void UpdateAttachPointVelocityData(Transform attachTransform, Transform xrOriginTransform)
		{
		}

		private void UpdateAttachPointVelocityData(Transform attachTransformRef, bool useXROriginTransform, Transform xrOriginTransform = null)
		{
		}

		internal void ResetVelocityTracking()
		{
		}

		public Vector3 GetAttachPointVelocity()
		{
			return default(Vector3);
		}

		public Vector3 GetAttachPointAngularVelocity()
		{
			return default(Vector3);
		}
	}
}
