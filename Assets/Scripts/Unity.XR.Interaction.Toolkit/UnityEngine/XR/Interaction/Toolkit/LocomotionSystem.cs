using System;
using Unity.XR.CoreUtils;
using UnityEngine.Serialization;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/Locomotion/Legacy/Locomotion System", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.LocomotionSystem.html")]
	[Obsolete("LocomotionSystem is deprecated and will be removed in a future release. Use LocomotionMediator instead.", false)]
	public class LocomotionSystem : MonoBehaviour
	{
		private LocomotionProvider m_CurrentExclusiveProvider;

		private float m_TimeMadeExclusive;

		[SerializeField]
		[Tooltip("The timeout (in seconds) for exclusive access to the XR Origin.")]
		private float m_Timeout;

		[SerializeField]
		[FormerlySerializedAs("m_XRRig")]
		[Tooltip("The XR Origin object to provide access control to.")]
		private XROrigin m_XROrigin;

		public float timeout
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public XROrigin xrOrigin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool busy => false;

		[Obsolete("xrRig is marked for deprecation and will be removed in a future version. Please use xrOrigin instead.", true)]
		public XRRig xrRig
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("Busy has been deprecated. Use busy instead. (UnityUpgradable) -> busy", true)]
		public bool Busy => false;

		protected void Awake()
		{
		}

		protected void Update()
		{
		}

		public RequestResult RequestExclusiveOperation(LocomotionProvider provider)
		{
			return default(RequestResult);
		}

		private void ResetExclusivity()
		{
		}

		public RequestResult FinishExclusiveOperation(LocomotionProvider provider)
		{
			return default(RequestResult);
		}
	}
}
