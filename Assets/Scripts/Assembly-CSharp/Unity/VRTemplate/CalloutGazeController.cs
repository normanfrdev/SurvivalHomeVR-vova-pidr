using UnityEngine;
using UnityEngine.Events;

namespace Unity.VRTemplate
{
	public class CalloutGazeController : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The transform which the forward direction will be used to evaluate as the gaze direction.")]
		private Transform m_GazeTransform;

		[SerializeField]
		[Tooltip("Threshold for the dot product when determining if the Gaze Transform is facing this object. The lower the threshold, the wider the field of view.")]
		[Range(0f, 1f)]
		private float m_FacingThreshold;

		[SerializeField]
		[Tooltip("Events fired when the Gaze Transform begins facing this game object")]
		private UnityEvent m_FacingEntered;

		[SerializeField]
		[Tooltip("Events fired when the Gaze Transform stops facing this game object")]
		private UnityEvent m_FacingExited;

		[SerializeField]
		[Tooltip("Distance threshold for movement in a single frame that determines a large movement that will trigger Facing Exited events.")]
		private float m_LargeMovementDistanceThreshold;

		[SerializeField]
		[Tooltip("Cool down time after a large movement for Facing Entered events to fire again.")]
		private float m_LargeMovementCoolDownTime;

		private bool m_IsFacing;

		private float m_LargeMovementCoolDown;

		private Vector3 m_LastPosition;

		private void Update()
		{
		}

		private void CheckLargeMovement()
		{
		}

		private void FacingEntered()
		{
		}

		private void FacingExited()
		{
		}
	}
}
