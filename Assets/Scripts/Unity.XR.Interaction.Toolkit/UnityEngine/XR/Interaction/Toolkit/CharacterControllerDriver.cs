using System;
using Unity.XR.CoreUtils;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/Locomotion/Legacy/Character Controller Driver", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.CharacterControllerDriver.html")]
	[Obsolete("CharacterControllerDriver is deprecated in XRI 3.0.0 and will be removed in a future release. Instead set useCharacterControllerIfExists to true on the instance of XRBodyTransformer in the scene, and then, if at runtime, re-enable the Body Transformer to make the locomotion system drive the CharacterController.", false)]
	public class CharacterControllerDriver : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The Locomotion Provider object to listen to.")]
		private LocomotionProvider m_LocomotionProvider;

		[SerializeField]
		[Tooltip("The minimum height of the character's capsule that will be set by this behavior.")]
		private float m_MinHeight;

		[SerializeField]
		[Tooltip("The maximum height of the character's capsule that will be set by this behavior.")]
		private float m_MaxHeight;

		private XROrigin m_XROrigin;

		private CharacterController m_CharacterController;

		public LocomotionProvider locomotionProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float minHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected XROrigin xrOrigin => null;

		[Obsolete("xrRig has been deprecated. Use xrOrigin instead.", true)]
		protected XRRig xrRig => null;

		protected CharacterController characterController => null;

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Start()
		{
		}

		protected virtual void UpdateCharacterController()
		{
		}

		private void Subscribe(LocomotionProvider provider)
		{
		}

		private void Unsubscribe(LocomotionProvider provider)
		{
		}

		private void SetupCharacterController()
		{
		}

		private void OnBeginLocomotion(LocomotionSystem system)
		{
		}

		private void OnEndLocomotion(LocomotionSystem system)
		{
		}
	}
}
