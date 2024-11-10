using System.Diagnostics;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.AR.Inputs
{
	[AddComponentMenu("XR/Input/Screen Space Rotate Input", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AR.Inputs.ScreenSpaceRotateInput.html")]
	public class ScreenSpaceRotateInput : MonoBehaviour, IXRInputValueReader<Vector2>, IXRInputValueReader
	{
		[SerializeField]
		[Tooltip("The ray interactor to get the attach transform from.")]
		private XRRayInteractor m_RayInteractor;

		[SerializeField]
		[Tooltip("The input used to read the twist delta rotation value.")]
		private XRInputValueReader<float> m_TwistDeltaRotationInput;

		[SerializeField]
		[Tooltip("The input used to read the drag delta value.")]
		private XRInputValueReader<Vector2> m_DragDeltaInput;

		[SerializeField]
		[Tooltip("The input used to read the screen touch count value.")]
		private XRInputValueReader<int> m_ScreenTouchCountInput;

		public XRRayInteractor rayInteractor
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<float> twistDeltaRotationInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<Vector2> dragDeltaInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XRInputValueReader<int> screenTouchCountInput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Conditional("UNITY_EDITOR")]
		protected void Reset()
		{
		}

		protected void Awake()
		{
		}

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public Vector2 ReadValue()
		{
			return default(Vector2);
		}

		public bool TryReadValue(out Vector2 value)
		{
			value = default(Vector2);
			return false;
		}
	}
}
