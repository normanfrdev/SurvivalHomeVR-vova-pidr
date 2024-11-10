using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace Unity.VRTemplate
{
	public class XRKnob : XRBaseInteractable
	{
		private struct TrackedRotation
		{
			private float m_BaseAngle;

			private float m_CurrentOffset;

			private float m_AccumulatedAngle;

			public float totalOffset => 0f;

			public void Reset()
			{
			}

			public void SetBaseFromVector(Vector3 direction)
			{
			}

			public void SetTargetFromVector(Vector3 direction)
			{
			}
		}

		[Serializable]
		[Tooltip("Event called when the value of the knob is changed")]
		public class ValueChangeEvent : UnityEvent<float>
		{
			public ValueChangeEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		private const float k_ModeSwitchDeadZone = 0.1f;

		[SerializeField]
		[Tooltip("The object that is visually grabbed and manipulated")]
		private Transform m_Handle;

		[SerializeField]
		[Tooltip("The value of the knob")]
		[Range(0f, 1f)]
		private float m_Value;

		[SerializeField]
		[Tooltip("Whether this knob's rotation should be clamped by the angle limits")]
		private bool m_ClampedMotion;

		[SerializeField]
		[Tooltip("Rotation of the knob at value '1'")]
		private float m_MaxAngle;

		[SerializeField]
		[Tooltip("Rotation of the knob at value '0'")]
		private float m_MinAngle;

		[SerializeField]
		[Tooltip("Angle increments to support, if greater than '0'")]
		private float m_AngleIncrement;

		[SerializeField]
		[Tooltip("The position of the interactor controls rotation when outside this radius")]
		private float m_PositionTrackedRadius;

		[SerializeField]
		[Tooltip("How much controller rotation")]
		private float m_TwistSensitivity;

		[SerializeField]
		[Tooltip("Events to trigger when the knob is rotated")]
		private ValueChangeEvent m_OnValueChange;

		private IXRSelectInteractor m_Interactor;

		private bool m_PositionDriven;

		private bool m_UpVectorDriven;

		private TrackedRotation m_PositionAngles;

		private TrackedRotation m_UpVectorAngles;

		private TrackedRotation m_ForwardVectorAngles;

		private float m_BaseKnobRotation;

		public Transform handle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float value
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool clampedMotion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float maxAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float minAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float positionTrackedRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ValueChangeEvent onValueChange => null;

		private void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void StartGrab(SelectEnterEventArgs args)
		{
		}

		private void EndGrab(SelectExitEventArgs args)
		{
		}

		public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
		{
		}

		public override Transform GetAttachTransform(IXRInteractor interactor)
		{
			return null;
		}

		private void UpdateRotation(bool freshCheck = false)
		{
		}

		private void SetKnobRotation(float angle)
		{
		}

		private void SetValue(float newValue)
		{
		}

		private float ValueToRotation()
		{
			return 0f;
		}

		private void UpdateBaseKnobRotation()
		{
		}

		private static float ShortestAngleDistance(float start, float end, float max)
		{
			return 0f;
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnValidate()
		{
		}
	}
}
