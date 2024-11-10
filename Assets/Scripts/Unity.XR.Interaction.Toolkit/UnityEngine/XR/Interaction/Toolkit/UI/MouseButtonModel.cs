using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	public struct MouseButtonModel
	{
		internal struct ImplementationData
		{
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

		private bool m_IsDown;

		private ImplementationData m_ImplementationData;

		public bool isDown
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal ButtonDeltaState lastFrameDelta
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
