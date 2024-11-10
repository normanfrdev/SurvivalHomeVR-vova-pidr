using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	internal struct MouseModel
	{
		internal struct InternalData
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

			public void Reset()
			{
			}
		}

		private int m_DisplayIndex;

		private Vector2 m_Position;

		private Vector2 m_ScrollDelta;

		private MouseButtonModel m_LeftButton;

		private MouseButtonModel m_RightButton;

		private MouseButtonModel m_MiddleButton;

		private InternalData m_InternalData;

		public readonly int pointerId
		{
			[CompilerGenerated]
			get
			{
				return 0;
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

		public int displayIndex
		{
			get
			{
				return 0;
			}
			set
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

		public MouseButtonModel leftButton
		{
			get
			{
				return default(MouseButtonModel);
			}
			set
			{
			}
		}

		public bool leftButtonPressed
		{
			set
			{
			}
		}

		public MouseButtonModel rightButton
		{
			get
			{
				return default(MouseButtonModel);
			}
			set
			{
			}
		}

		public bool rightButtonPressed
		{
			set
			{
			}
		}

		public MouseButtonModel middleButton
		{
			get
			{
				return default(MouseButtonModel);
			}
			set
			{
			}
		}

		public bool middleButtonPressed
		{
			set
			{
			}
		}

		public MouseModel(int pointerId)
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
