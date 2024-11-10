using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.XR.CoreUtils.Collections;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityEngine.XR.Interaction.Toolkit.Utilities;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	[DisallowMultipleComponent]
	[AddComponentMenu("XR/Interactors/XR Socket Interactor", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Interactors.XRSocketInteractor.html")]
	public class XRSocketInteractor : XRBaseInteractor
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		private struct ShaderPropertyLookup
		{
			public static readonly int surface;

			public static readonly int mode;

			public static readonly int srcBlend;

			public static readonly int dstBlend;

			public static readonly int zWrite;

			public static readonly int baseColor;

			public static readonly int color;
		}

		[CompilerGenerated]
		private sealed class _003CUpdateCollidersAfterOnTriggerStay_003Ed__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XRSocketInteractor _003C_003E4__this;

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
			public _003CUpdateCollidersAfterOnTriggerStay_003Ed__67(int _003C_003E1__state)
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
		private bool m_ShowInteractableHoverMeshes;

		[SerializeField]
		private Material m_InteractableHoverMeshMaterial;

		[SerializeField]
		private Material m_InteractableCantHoverMeshMaterial;

		[SerializeField]
		private bool m_SocketActive;

		[SerializeField]
		private float m_InteractableHoverScale;

		[SerializeField]
		private float m_RecycleDelayTime;

		private float m_LastRemoveTime;

		[SerializeField]
		private bool m_HoverSocketSnapping;

		[SerializeField]
		private float m_SocketSnappingRadius;

		[SerializeField]
		private SocketScaleMode m_SocketScaleMode;

		[SerializeField]
		private Vector3 m_FixedScale;

		[SerializeField]
		private Vector3 m_TargetBoundsSize;

		private readonly HashSet<Collider> m_StayedColliders;

		private readonly TriggerContactMonitor m_TriggerContactMonitor;

		private readonly Dictionary<IXRInteractable, (MeshFilter, Renderer)[]> m_MeshFilterCache;

		private static readonly List<MeshFilter> s_MeshFilters;

		private static readonly WaitForFixedUpdate s_WaitForFixedUpdate;

		private IEnumerator m_UpdateCollidersAfterTriggerStay;

		private readonly XRSocketGrabTransformer m_SocketGrabTransformer;

		private readonly HashSetList<XRGrabInteractable> m_InteractablesWithSocketTransformer;

		public bool showInteractableHoverMeshes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Material interactableHoverMeshMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material interactableCantHoverMeshMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool socketActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float interactableHoverScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float recycleDelayTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool hoverSocketSnapping
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float socketSnappingRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SocketScaleMode socketScaleMode
		{
			get
			{
				return default(SocketScaleMode);
			}
			set
			{
			}
		}

		public Vector3 fixedScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 targetBoundsSize
		{
			get
			{
				return default(Vector3);
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

		protected virtual int socketSnappingLimit => 0;

		protected virtual bool ejectExistingSocketsWhenSnapping => false;

		public override bool isHoverActive => false;

		public override bool isSelectActive => false;

		public override XRBaseInteractable.MovementType? selectedInteractableMovementTypeOverride => null;

		private bool isHoverRecycleAllowed => false;

		protected virtual void OnValidate()
		{
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

		[IteratorStateMachine(typeof(_003CUpdateCollidersAfterOnTriggerStay_003Ed__67))]
		private IEnumerator UpdateCollidersAfterOnTriggerStay()
		{
			return null;
		}

		public override void ProcessInteractor(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		protected virtual void CreateDefaultHoverMaterials()
		{
		}

		private static void SetMaterialFade(Material material, Color color)
		{
		}

		protected override void OnHoverEntering(HoverEnterEventArgs args)
		{
		}

		protected override void OnHoverEntered(HoverEnterEventArgs args)
		{
		}

		protected virtual bool CanHoverSnap(IXRInteractable interactable)
		{
			return false;
		}

		protected override void OnHoverExiting(HoverExitEventArgs args)
		{
		}

		protected override void OnSelectEntered(SelectEnterEventArgs args)
		{
		}

		protected override void OnSelectExiting(SelectExitEventArgs args)
		{
		}

		protected override void OnSelectExited(SelectExitEventArgs args)
		{
		}

		private Matrix4x4 GetHoverMeshMatrix(IXRInteractable interactable, MeshFilter meshFilter, float hoverScale)
		{
			return default(Matrix4x4);
		}

		private static Vector3 InverseTransformDirection(Pose pose, Vector3 direction)
		{
			return default(Vector3);
		}

		protected virtual void DrawHoveredInteractables()
		{
		}

		protected virtual Material GetHoveredInteractableMaterial(IXRHoverInteractable interactable)
		{
			return null;
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

		protected virtual bool ShouldDrawHoverMesh(MeshFilter meshFilter, Renderer meshRenderer, Camera mainCamera)
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

		protected virtual bool StartSocketSnapping(XRGrabInteractable grabInteractable)
		{
			return false;
		}

		protected virtual bool EndSocketSnapping(XRGrabInteractable grabInteractable)
		{
			return false;
		}

		private void SyncTransformerParams()
		{
		}
	}
}
