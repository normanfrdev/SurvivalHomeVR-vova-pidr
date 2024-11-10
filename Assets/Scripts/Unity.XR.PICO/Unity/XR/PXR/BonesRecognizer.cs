using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.PXR
{
	[Serializable]
	public class BonesRecognizer
	{
		[Serializable]
		public class BonesGroup
		{
			[Label("Joint 1")]
			public HandBones bone1;

			[Label("Joint 2")]
			public HandBones bone2;

			public float distance;

			[Label("Margin")]
			public float thresholdWidth;

			[HideInInspector]
			public bool activeState;
		}

		public enum HandBones
		{
			Palm = 0,
			Wrist = 1,
			Thumb_Metacarpal = 2,
			Thumb_Proximal = 3,
			Thumb_Distal = 4,
			Thumb_Tip = 5,
			Index_Metacarpal = 6,
			Index_Proximal = 7,
			Index_Intermediate = 8,
			Index_Distal = 9,
			Index_Tip = 10,
			Middle_Metacarpal = 11,
			Middle_Proximal = 12,
			Middle_Intermediate = 13,
			Middle_Distal = 14,
			Middle_Tip = 15,
			Ring_Metacarpal = 16,
			Ring_Proximal = 17,
			Ring_Intermediate = 18,
			Ring_Distal = 19,
			Ring_Tip = 20,
			Little_Metacarpal = 21,
			Little_Proximal = 22,
			Little_Intermediate = 23,
			Little_Distal = 24,
			Little_Tip = 25
		}

		public List<BonesGroup> Bones;

		public float holdDuration;
	}
}
