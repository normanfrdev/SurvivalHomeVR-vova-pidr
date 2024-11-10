using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	public class ControllerAnimator : MonoBehaviour
	{
		[Header("Thumbstick")]
		[SerializeField]
		private Transform m_ThumbstickTransform;

		[SerializeField]
		private Vector2 m_StickRotationRange;

		[SerializeField]
		private XRInputValueReader<Vector2> m_StickInput;

		[Header("Trigger")]
		[SerializeField]
		private Transform m_TriggerTransform;

		[SerializeField]
		private Vector2 m_TriggerXAxisRotationRange;

		[SerializeField]
		private XRInputValueReader<float> m_TriggerInput;

		[Header("Grip")]
		[SerializeField]
		private Transform m_GripTransform;

		[SerializeField]
		private Vector2 m_GripRightRange;

		[SerializeField]
		private XRInputValueReader<float> m_GripInput;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}
	}
}
