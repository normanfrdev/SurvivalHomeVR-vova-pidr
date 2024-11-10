using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing
{
	[AddComponentMenu("XR/Locomotion/Climb Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing.ClimbProvider.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class ClimbProvider : LocomotionProvider
	{
		private readonly List<IXRSelectInteractor> m_GrabbingInteractors;

		private readonly List<ClimbInteractable> m_GrabbedClimbables;

		private Vector3 m_InteractorAnchorWorldPosition;

		private Vector3 m_InteractorAnchorClimbSpacePosition;

		[SerializeField]
		[Tooltip("Climb locomotion settings. Can be overridden by the Climb Interactable used for locomotion.")]
		private ClimbSettingsDatumProperty m_ClimbSettings;

		public ClimbSettingsDatumProperty climbSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ClimbInteractable climbAnchorInteractable => null;

		public IXRSelectInteractor climbAnchorInteractor => null;

		public XROriginMovement transformation
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

		public event Action<ClimbProvider> climbAnchorUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		public void StartClimbGrab(ClimbInteractable climbInteractable, IXRSelectInteractor interactor)
		{
		}

		public void FinishClimbGrab(IXRSelectInteractor interactor)
		{
		}

		private void UpdateClimbAnchor(ClimbInteractable climbInteractable, IXRInteractor interactor)
		{
		}

		protected virtual void Update()
		{
		}

		private void StepClimbMovement(ClimbInteractable currentClimbInteractable, IXRSelectInteractor currentInteractor)
		{
		}

		private void FinishLocomotion()
		{
		}

		private ClimbSettings GetActiveClimbSettings(ClimbInteractable climbInteractable)
		{
			return null;
		}
	}
}
