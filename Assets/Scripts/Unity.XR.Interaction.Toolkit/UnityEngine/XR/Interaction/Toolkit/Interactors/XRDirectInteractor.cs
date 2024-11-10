using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/Interactors/XR Direct Interactor", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.XRDirectInteractor.html")]
	public class XRDirectInteractor : XRBaseInputInteractor
	{
		[CompilerGenerated]
		private sealed class _003CUpdateCollidersAfterOnTriggerStay_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XRDirectInteractor _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CUpdateCollidersAfterOnTriggerStay_003Ed__36(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private bool m_ImproveAccuracyWithSphereCollider;

		[SerializeField]
		private LayerMask m_PhysicsLayerMask;

		[SerializeField]
		private QueryTriggerInteraction m_PhysicsTriggerInteraction;

		private readonly HashSet<Collider> m_StayedColliders;

		private readonly TriggerContactMonitor m_TriggerContactMonitor;

		private static readonly WaitForFixedUpdate s_WaitForFixedUpdate;

		private IEnumerator m_UpdateCollidersAfterTriggerStay;

		private bool m_UsingSphereColliderAccuracyImprovement;

		private SphereCollider m_SphereCollider;

		private PhysicsScene m_LocalPhysicsScene;

		private Vector3 m_LastSphereCastOrigin;

		private readonly Collider[] m_OverlapSphereHits;

		private readonly RaycastHit[] m_SphereCastHits;

		private bool m_FirstFrame;

		private bool m_ContactsSortedThisFrame;

		private readonly List<IXRInteractable> m_SortedValidTargets;

		public bool improveAccuracyWithSphereCollider
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool usingSphereColliderAccuracyImprovement => false;

		public LayerMask physicsLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public QueryTriggerInteraction physicsTriggerInteraction
		{
			get
			{
				return default(QueryTriggerInteraction);
			}
			set
			{
			}
		}

		protected List<IXRInteractable> unsortedValidTargets
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected void OnTriggerEnter(Collider other)
		{
		}

		protected void OnTriggerStay(Collider other)
		{
		}

		protected void OnTriggerExit(Collider other)
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateCollidersAfterOnTriggerStay_003Ed__36))]
		private IEnumerator UpdateCollidersAfterOnTriggerStay()
		{
			return null;
		}

		public override void PreprocessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public override void ProcessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		private void EvaluateSphereOverlap()
		{
		}

		private void ValidateColliderConfiguration()
		{
		}

		public override void GetValidTargets(List<IXRInteractable> targets)
		{
		}

		public override bool CanHover(IXRHoverInteractable interactable)
		{
			return false;
		}

		public override bool CanSelect(IXRSelectInteractable interactable)
		{
			return false;
		}

		protected override void OnRegistered(InteractorRegisteredEventArgs args)
		{
		}

		protected override void OnUnregistered(InteractorUnregisteredEventArgs args)
		{
		}

		private void OnInteractableRegistered(InteractableRegisteredEventArgs args)
		{
		}

		private void OnInteractableUnregistered(InteractableUnregisteredEventArgs args)
		{
		}

		private void OnContactAdded(IXRInteractable interactable)
		{
		}

		private void OnContactRemoved(IXRInteractable interactable)
		{
		}

		private void ResetCollidersAndValidTargets()
		{
		}
	}
}
