using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	internal struct TouchModel
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

		private TouchPhase m_SelectPhase;

		private Vector2 m_Position;

		private ImplementationData m_ImplementationData;

		public readonly int pointerId
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public TouchPhase selectPhase
		{
			get
			{
				return default(TouchPhase);
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

		public Vector2 position
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 deltaPosition
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TouchModel(int pointerId)
		{
		}

		public void Reset()
		{
		}

		public void OnFrameFinished()
		{
		}

		public void CopyTo(PointerEventData eventData)
		{
		}

		public void CopyFrom(PointerEventData eventData)
		{
		}
	}
}
