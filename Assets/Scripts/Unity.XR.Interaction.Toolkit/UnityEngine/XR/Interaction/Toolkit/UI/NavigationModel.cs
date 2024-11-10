using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.XR.Interaction.Toolkit.UI
{
	internal struct NavigationModel
	{
		public struct ImplementationData
		{
			public int consecutiveMoveCount
			{
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public MoveDirection lastMoveDirection
			{
				[CompilerGenerated]
				readonly get
				{
					return default(MoveDirection);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float lastMoveTime
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

			public void Reset()
			{
			}
		}

		private bool m_SubmitButtonDown;

		private bool m_CancelButtonDown;

		public Vector2 move
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

		public bool submitButtonDown
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal ButtonDeltaState submitButtonDelta
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

		public bool cancelButtonDown
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal ButtonDeltaState cancelButtonDelta
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

		internal ImplementationData implementationData
		{
			[CompilerGenerated]
			readonly get
			{
				return default(ImplementationData);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Reset()
		{
		}

		public void OnFrameFinished()
		{
		}
	}
}
