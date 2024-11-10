using System;
using UnityEngine.SpatialTracking;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Serializable]
	public class XRControllerState
	{
		public double time;

		public InputTrackingState inputTrackingState;

		public bool isTracked;

		public Vector3 position;

		public Quaternion rotation;

		public InteractionState selectInteractionState;

		public InteractionState activateInteractionState;

		public InteractionState uiPressInteractionState;

		public Vector2 uiScrollValue;

		[Obsolete("poseDataFlags has been deprecated. Use inputTrackingState instead.", true)]
		public PoseDataFlags poseDataFlags
		{
			get
			{
				return default(PoseDataFlags);
			}
			set
			{
			}
		}

		protected XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool isTracked)
		{
		}

		public XRControllerState()
		{
		}

		public XRControllerState(XRControllerState value)
		{
		}

		public XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool isTracked, bool selectActive, bool activateActive, bool pressActive)
		{
		}

		public XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool isTracked, bool selectActive, bool activateActive, bool pressActive, float selectValue, float activateValue, float pressValue)
		{
		}

		public void ResetFrameDependentStates()
		{
		}

		public override string ToString()
		{
			return null;
		}

		[Obsolete("This constructor has been deprecated. Use the constructors with the inputTrackingState parameter.", true)]
		public XRControllerState(double time, Vector3 position, Quaternion rotation, bool selectActive, bool activateActive, bool pressActive)
		{
		}

		[Obsolete("This constructor has been deprecated. Use the constructor with the isTracked parameter.", true)]
		protected XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState)
		{
		}

		[Obsolete("This constructor has been deprecated. Use the constructor with the isTracked parameter.", true)]
		public XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool selectActive, bool activateActive, bool pressActive)
		{
		}

		[Obsolete("This constructor has been deprecated. Use the constructor with the isTracked parameter.", true)]
		public XRControllerState(double time, Vector3 position, Quaternion rotation, InputTrackingState inputTrackingState, bool selectActive, bool activateActive, bool pressActive, float selectValue, float activateValue, float pressValue)
		{
		}

		[Obsolete("ResetInputs has been renamed. Use ResetFrameDependentStates instead. (UnityUpgradable) -> ResetFrameDependentStates()", true)]
		public void ResetInputs()
		{
		}
	}
}
