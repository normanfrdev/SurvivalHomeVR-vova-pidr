using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	public struct TrackedDeviceModel
	{
		internal struct ImplementationData
		{
			public List<GameObject> hoverTargets
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public GameObject pointerTarget
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool isDragging
			{
				[CompilerGenerated]
				readonly get
				{
					return false;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float pressedTime
			{
				[CompilerGenerated]
				readonly get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Vector2 position
			{
				[CompilerGenerated]
				readonly get
				{
					return default(Vector2);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Vector2 pressedPosition
			{
				[CompilerGenerated]
				readonly get
				{
					return default(Vector2);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public Vector3 pressedWorldPosition
			{
				[CompilerGenerated]
				readonly get
				{
					return default(Vector3);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public RaycastResult pressedRaycast
			{
				[CompilerGenerated]
				readonly get
				{
					return default(RaycastResult);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public GameObject pressedGameObject
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public GameObject pressedGameObjectRaw
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public GameObject draggedGameObject
			{
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public void Reset()
			{
			}
		}

		private ImplementationData m_ImplementationData;

		private bool m_SelectDown;

		private Vector3 m_Position;

		private Quaternion m_Orientation;

		private List<Vector3> m_RaycastPoints;

		private LayerMask m_RaycastLayerMask;

		private Vector2 m_ScrollDelta;

		private float m_PokeDepth;

		private UIInteractionType m_InteractionType;

		internal ImplementationData implementationData => default(ImplementationData);

		public readonly int pointerId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public bool select
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ButtonDeltaState selectDelta
		{
			[CompilerGenerated]
			readonly get
			{
				return default(ButtonDeltaState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool changedThisFrame
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		internal Func<Vector3> positionGetter
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Quaternion orientation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public List<Vector3> raycastPoints
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RaycastResult currentRaycast
		{
			[CompilerGenerated]
			readonly get
			{
				return default(RaycastResult);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int currentRaycastEndpointIndex
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LayerMask raycastLayerMask
		{
			get
			{
				return default(LayerMask);
			}
			set
			{
			}
		}

		public Vector2 scrollDelta
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		internal float pokeDepth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		internal UIInteractionType interactionType
		{
			get
			{
				return default(UIInteractionType);
			}
			set
			{
			}
		}

		public GameObject selectableObject
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isScrollable
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal static TrackedDeviceModel invalid
		{
			[CompilerGenerated]
			get
			{
				return default(TrackedDeviceModel);
			}
		}

		[Obsolete("maxRaycastDistance has been deprecated. Its value was unused, calling this property is unnecessary and should be removed.", true)]
		public float maxRaycastDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public TrackedDeviceModel(int pointerId)
		{
		}

		public void Reset(bool resetImplementation = true)
		{
		}

		public void OnFrameFinished()
		{
		}

		public void CopyTo(TrackedDeviceEventData eventData)
		{
		}

		public void CopyFrom(TrackedDeviceEventData eventData)
		{
		}
	}
}
