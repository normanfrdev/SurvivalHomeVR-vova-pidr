using System;
using UnityEngine;

namespace Unity.XR.PXR
{
	[Serializable]
	public class PXR_HandPoseConfig : ScriptableObject
	{
		[DisplayOnly]
		public ShapesRecognizer shapesRecognizer;

		[DisplayOnly]
		public BonesRecognizer bonesRecognizer;

		[DisplayOnly]
		public TransRecognizer transRecognizer;
	}
}
