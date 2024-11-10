using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[AddComponentMenu("XR/Interactors/XR Gaze Interactor", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.XRGazeInteractor.html")]
	public class XRGazeInteractor : XRRayInteractor
	{
		public enum GazeAssistanceCalculation
		{
			FixedSize = 0,
			ColliderSize = 1
		}

		[SerializeField]
		private GazeAssistanceCalculation m_GazeAssistanceCalculation;

		[SerializeField]
		private float m_GazeAssistanceColliderFixedSize;

		[SerializeField]
		private float m_GazeAssistanceColliderScale;

		[SerializeField]
		private XRInteractableSnapVolume m_GazeAssistanceSnapVolume;

		[SerializeField]
		private bool m_GazeAssistanceDistanceScaling;

		[SerializeField]
		private bool m_ClampGazeAssistanceDistanceScaling;

		[SerializeField]
		private float m_GazeAssistanceDistanceScalingClampValue;

		public GazeAssistanceCalculation gazeAssistanceCalculation
		{
			get
			{
				return default(GazeAssistanceCalculation);
			}
			set
			{
			}
		}

		public float gazeAssistanceColliderFixedSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float gazeAssistanceColliderScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public XRInteractableSnapVolume gazeAssistanceSnapVolume
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool gazeAssistanceDistanceScaling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool clampGazeAssistanceDistanceScaling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float gazeAssistanceDistanceScalingClampValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void CreateGazeAssistanceSnapVolume()
		{
		}

		public override void PreprocessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		protected virtual void UpdateSnapVolumeInteractable(IXRInteractable interactable)
		{
		}

		private float CalculateSnapColliderSize(Collider interactableCollider)
		{
			return 0f;
		}

		private bool CanInteract(IXRInteractable interactable)
		{
			return false;
		}

		protected override float GetHoverTimeToSelect(IXRInteractable interactable)
		{
			return 0f;
		}

		protected override float GetTimeToAutoDeselect(IXRInteractable interactable)
		{
			return 0f;
		}
	}
}
