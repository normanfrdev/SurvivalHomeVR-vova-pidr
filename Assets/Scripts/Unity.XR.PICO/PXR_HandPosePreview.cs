using System;
using System.Collections.Generic;
using Unity.XR.PXR;
using UnityEngine;

[ExecuteInEditMode]
public class PXR_HandPosePreview : MonoBehaviour
{
	[Serializable]
	public class ModelFinger
	{
		public enum ModelJoint
		{
			metacarpal = 0,
			proximal = 1,
			intermediate = 2,
			distal = 3,
			tip = 4
		}

		public enum FingerType
		{
			thumb = 0,
			index = 1,
			middle = 2,
			ring = 3,
			little = 4
		}

		public FingerType Type;

		public List<Transform> flexionTransforms;

		public List<MeshRenderer> flexionMeshRenderers;

		public List<Transform> curlTransforms;

		public List<MeshRenderer> curlMeshRenderers;

		public ModelFinger(FingerType type)
		{
		}

		public void RefreshModelJoints(Transform transform)
		{
		}

		public void HighlightModelJoints(PXR_HandPosePreview handPosePreview, ShapesRecognizer.Flexion flexion, ShapesRecognizer.Curl curl)
		{
		}

		private Transform GetModelJoint(Transform tran, ModelJoint type)
		{
			return null;
		}
	}

	[HideInInspector]
	public List<Transform> handJoints;

	[HideInInspector]
	public Vector3[] jointAngles;

	[HideInInspector]
	public Transform posePreviewX;

	[HideInInspector]
	public Transform posePreviewY;

	[HideInInspector]
	public Transform handModel;

	[HideInInspector]
	public SkinnedMeshRenderer handAxis;

	[HideInInspector]
	public Transform headModel;

	[HideInInspector]
	public Transform handShadow;

	[HideInInspector]
	public ModelFinger modelThumb;

	[HideInInspector]
	public ModelFinger modelIndex;

	[HideInInspector]
	public ModelFinger modelMiddle;

	[HideInInspector]
	public ModelFinger modelRing;

	[HideInInspector]
	public ModelFinger modelLittle;

	[HideInInspector]
	public Material openMaterial;

	[HideInInspector]
	public Material anyMaterial;

	[HideInInspector]
	public Material openFadeMaterial;

	[HideInInspector]
	public Material anyFadeMaterial;

	[HideInInspector]
	public Material highLightMaterial;

	private Vector4 highLightBlendPower;

	private int blendPower;

	public void UpdateShapeState(ShapesRecognizer shapesConfig)
	{
	}

	public void ResetShapeState()
	{
	}

	public void ResetTransformState()
	{
	}

	public void UpdateTransformState(TransRecognizer transRecognizer)
	{
	}
}
