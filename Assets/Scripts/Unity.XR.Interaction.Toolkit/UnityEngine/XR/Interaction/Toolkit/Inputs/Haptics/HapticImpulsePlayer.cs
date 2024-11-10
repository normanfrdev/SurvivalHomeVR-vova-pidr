namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics
{
	[AddComponentMenu("XR/Haptics/Haptic Impulse Player", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics.HapticImpulsePlayer.html")]
	public class HapticImpulsePlayer : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Specifies the output haptic control or controller that haptic impulses will be sent to.")]
		private XRInputHapticImpulseProvider m_HapticOutput;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Amplitude multiplier which can be used to dampen the haptic impulses sent by this component.")]
		private float m_AmplitudeMultiplier;

		public XRInputHapticImpulseProvider hapticOutput
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float amplitudeMultiplier
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

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public bool SendHapticImpulse(float amplitude, float duration)
		{
			return false;
		}

		public bool SendHapticImpulse(float amplitude, float duration, float frequency)
		{
			return false;
		}

		internal static HapticImpulsePlayer GetOrCreateInHierarchy(GameObject gameObject)
		{
			return null;
		}
	}
}
