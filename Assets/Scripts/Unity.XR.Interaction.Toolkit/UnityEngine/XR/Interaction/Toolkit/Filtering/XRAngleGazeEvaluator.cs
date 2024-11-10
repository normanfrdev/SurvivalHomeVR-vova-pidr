using System;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	[Serializable]
	public class XRAngleGazeEvaluator : XRTargetEvaluator
	{
		[Tooltip("The Transform whose forward direction is used to evaluate the target Interactable angle. If none is specified, during OnEnable this property is initialized with the XROrigin Camera.")]
		[SerializeField]
		private Transform m_GazeTransform;

		[Tooltip("The maximum value an angle can be evaluated as before the Interactor receives a normalized score of 0. Think of it as a field-of-view angle.")]
		[SerializeField]
		[Range(0f, 180f)]
		private float m_MaxAngle;

		public Transform gazeTransform
		{
			get
			{
				return null;
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

		private static Camera GetXROriginCamera()
		{
			return null;
		}

		private void InitializeGazeTransform()
		{
		}

		protected override void OnEnable()
		{
		}

		public override void Reset()
		{
		}

		protected override float CalculateNormalizedScore(IXRInteractor interactor, IXRInteractable target)
		{
			return 0f;
		}
	}
}
