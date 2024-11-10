using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	[AddComponentMenu("Event/Canvas Optimizer", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.UI.CanvasOptimizer.html")]
	public class CanvasOptimizer : MonoBehaviour
	{
		private class CanvasState
		{
			private class CanvasSettings
			{
				private AdditionalCanvasShaderChannels m_AdditionalShaderChannels;

				private float m_NormalizedSortingGridSize;

				private bool m_OverridePixelPerfect;

				private bool m_OverrideSorting;

				private float m_PlaneDistance;

				private float m_ReferencePixelsPerUnit;

				private RenderMode m_RenderMode;

				private float m_ScaleFactor;

				private int m_SortingLayerID;

				private string m_SortingLayerName;

				private int m_SortingOrder;

				private int m_TargetDisplay;

				public bool present
				{
					[CompilerGenerated]
					get
					{
						return false;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public void CopyFrom(Canvas source)
				{
				}

				public void CopyTo(Canvas dest)
				{
				}
			}

			private class CanvasScalerSettings
			{
				private float m_DefaultSpriteDPI;

				private float m_DynamicPixelsPerUnit;

				private float m_FallbackScreenDPI;

				private float m_MatchWidthOrHeight;

				private CanvasScaler.Unit m_PhysicalUnit;

				private float m_ReferencePixelsPerUnit;

				private Vector2 m_ReferenceResolution;

				private float m_ScaleFactor;

				private CanvasScaler.ScreenMatchMode m_ScreenMatchMode;

				private CanvasScaler.ScaleMode m_UiScaleMode;

				public bool present
				{
					[CompilerGenerated]
					get
					{
						return false;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public void CopyFrom(CanvasScaler source)
				{
				}

				public void CopyTo(CanvasScaler dest)
				{
				}
			}

			private class GraphicRaycasterSettings
			{
				private LayerMask m_BlockingMask;

				private GraphicRaycaster.BlockingObjects m_BlockingObjects;

				private bool m_IgnoreReversedGraphics;

				public bool present
				{
					[CompilerGenerated]
					get
					{
						return false;
					}
					[CompilerGenerated]
					set
					{
					}
				}

				public void CopyFrom(GraphicRaycaster source)
				{
				}

				public void CopyTo(GraphicRaycaster dest)
				{
				}
			}

			private const float k_CanvasCheckInterval = 0.5f;

			private CanvasTracker m_Tracker;

			private readonly CanvasSettings m_CanvasSettings;

			private readonly CanvasScalerSettings m_CanvasScalerSettings;

			private readonly GraphicRaycasterSettings m_GraphicRaycasterSettings;

			private bool m_WasNested;

			private bool m_Nested;

			private bool m_RaysDisabled;

			private Canvas m_Canvas;

			private GraphicRaycaster m_Raycaster;

			private TrackedDeviceGraphicRaycaster m_TrackedDeviceGraphicRaycaster;

			private float m_CheckTimer;

			internal void Initialize(CanvasTracker tracker)
			{
			}

			internal void CheckForNestedChanges(bool force = false)
			{
			}

			internal void CheckForOutOfView(Transform gazeSource, float fovAngle, float facingAngle, float maxDistance)
			{
			}
		}

		[SerializeField]
		[Tooltip("How wide of an field-of-view to use when determining if a canvas is in view.")]
		private float m_RayPositionIgnoreAngle;

		[SerializeField]
		[Tooltip("How much the camera and canvas rotate away from one another and still be considered facing.")]
		private float m_RayFacingIgnoreAngle;

		[SerializeField]
		[Tooltip("How far away a canvas can be from this camera and still receive input.")]
		private float m_RayPositionIgnoreDistance;

		private Camera m_CullingCamera;

		private Transform m_CullingCameraTransform;

		private readonly Dictionary<CanvasTracker, CanvasState> m_CanvasTrackers;

		public float rayPositionIgnoreAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rayFacingIgnoreAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rayPositionIgnoreDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void Update()
		{
		}

		public void RegisterCanvas(Canvas canvas)
		{
		}

		public void UnregisterCanvas(Canvas canvas)
		{
		}

		private static CanvasTracker InitializeCanvasTracking(Canvas target)
		{
			return null;
		}

		private void CheckForNestedCanvasChanges()
		{
		}

		private void CheckForOutOfViewCanvases()
		{
		}

		private void FindCullingCamera()
		{
		}
	}
}
