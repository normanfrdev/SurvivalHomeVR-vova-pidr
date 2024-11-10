using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.XR.PXR
{
	public class PXR_HandPose : MonoBehaviour
	{
		public enum TrackType
		{
			Any = 0,
			Left = 1,
			Right = 2
		}

		[Serializable]
		public class UpdateEvent : UnityEvent<float>
		{
			public UpdateEvent()
			{
				((UnityEvent<T0>)(object)this)._002Ector();
			}
		}

		public TrackType trackType;

		public PXR_HandPoseConfig config;

		public UnityEvent handPoseStart;

		public UpdateEvent handPoseUpdate;

		public UnityEvent handPoseEnd;

		private List<Vector3> leftJointPos;

		private List<Vector3> rightJointPos;

		private HandJointLocations leftHandJointLocations;

		private HandJointLocations rightHandJointLocations;

		private bool poseStateHold;

		private bool poseStateActive;

		private float poseStateHoldTime;

		private float shapesHoldDuration;

		private bool leftShapesHold;

		private bool leftShapesActive;

		private float leftShapesHoldTime;

		private bool rightShapesActive;

		private bool rightShapesHold;

		private float rightShapesHoldTime;

		private bool angleCheckValid;

		private bool abducCheckOpen;

		private Vector3 leftWirstPos;

		private Vector3 rightWirstPos;

		private Quaternion leftWirstRot;

		private Quaternion rightWirstRot;

		private Vector3 thumb0;

		private Vector3 thumb1;

		private Vector3 thumb2;

		private Vector3 thumb3;

		private Vector3 index0;

		private Vector3 index1;

		private Vector3 index2;

		private Vector3 index3;

		private Vector3 middle0;

		private Vector3 middle1;

		private Vector3 middle2;

		private Vector3 middle3;

		private Vector3 ring0;

		private Vector3 ring1;

		private Vector3 ring2;

		private Vector3 ring3;

		private Vector3 pinky0;

		private Vector3 pinky1;

		private Vector3 pinky2;

		private Vector3 pinky3;

		private bool thumbFlex;

		private bool indexFlex;

		private bool middleFlex;

		private bool ringFlex;

		private bool pinkyFlex;

		private bool thumbCurl;

		private bool indexCurl;

		private bool middleCurl;

		private bool ringCurl;

		private bool pinkyCurl;

		private bool thumbAbduc;

		private bool indexAbduc;

		private bool middleAbduc;

		private bool ringAbduc;

		private bool pinkyAbduc;

		private List<BonesRecognizer.BonesGroup> bones;

		private bool leftBonesHold;

		private bool leftBonesActive;

		private float leftBonesHoldTime;

		private bool rightBonesHold;

		private bool rightBonesActive;

		private float rightBonesHoldTime;

		private float bonesHoldDuration;

		private bool leftTransHold;

		private bool leftTransActive;

		private float leftTransHoldTime;

		private bool rightTransHold;

		private bool rightTransActive;

		private float rightTransHoldTime;

		private TransRecognizer.TrackAxis transTrackAxis;

		private TransRecognizer.SpaceType transSpaceType;

		private TransRecognizer.TrackTarget transTrackTarget;

		private float transAngleThreshold;

		private float transThresholdWidth;

		private float transHoldDuration;

		private Vector3 HMDpose;

		private Vector3 palmPos;

		private Vector3 palmAxis;

		private Vector3 targetPos;

		private void HandPoseEventCheck()
		{
		}

		private bool HoldCheck(bool holdState, float holdDuration, bool resultState, ref float holdTime)
		{
			return false;
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool ShapesRecognizerCheck(List<Vector3> jointPos, Vector3 wirstRight, Vector3 wirstForward, int wirstDirect = 1)
		{
			return false;
		}

		private bool FlexionCheck(ShapesRecognizer.Finger finger, Vector3 wirstRight, Vector3 wirstForward)
		{
			return false;
		}

		private bool CurlCheck(ShapesRecognizer.Finger finger)
		{
			return false;
		}

		private bool AbductionCheck(ShapesRecognizer.Finger finger)
		{
			return false;
		}

		private bool AngleCheck(float angle, float min, float max, float width, float rangeMin, float rangeMax)
		{
			return false;
		}

		private bool AbducCheck(float angle, float mid, float width)
		{
			return false;
		}

		private bool BonesCheck(HandType handType)
		{
			return false;
		}

		private Vector3 GetHandJoint(HandType hand, BonesRecognizer.HandBones bone)
		{
			return default(Vector3);
		}

		private bool TransCheck(TrackType trackType, Vector3 wristPos, Quaternion wristRot, Vector3 headPose, bool holdState)
		{
			return false;
		}

		private Vector3 GetTrackAxis(TrackType trackType, Quaternion wristRot)
		{
			return default(Vector3);
		}

		private Vector3 GetProjectedTarget(Vector3 headPose, Quaternion wristRot, Vector3 wristPos)
		{
			return default(Vector3);
		}
	}
}
