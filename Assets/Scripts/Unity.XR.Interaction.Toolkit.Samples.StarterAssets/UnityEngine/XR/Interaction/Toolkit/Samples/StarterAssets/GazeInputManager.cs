using UnityEngine.InputSystem;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	public class GazeInputManager : MonoBehaviour
	{
		private const string k_EyeGazeLayoutName = "EyeGaze";

		[SerializeField]
		[Tooltip("Enable fallback to head tracking if eye tracking is unavailable.")]
		private bool m_FallbackIfEyeTrackingUnavailable;

		private bool m_EyeTrackingDeviceFound;

		public bool fallbackIfEyeTrackingUnavailable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void OnDestroy()
		{
		}

		private void OnDeviceConnected(InputDevice inputDevice)
		{
		}

		private void OnDeviceChange(UnityEngine.InputSystem.InputDevice device, InputDeviceChange change)
		{
		}
	}
}
