using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.XR.PXR;
using UnityEngine;

public class PXR_Hand : MonoBehaviour
{
	public HandType handType;

	public Transform Basemesh;

	[HideInInspector]
	public List<Transform> handJoints;

	private HandJointLocations handJointLocations;

	private HandAimState aimState;

	[SerializeField]
	private Transform rayPose;

	[SerializeField]
	private GameObject defaultRay;

	private SkinnedMeshRenderer[] touchRenders;

	private bool isaAdaptiveScales;

	private PXR_VstModelPosCheck mOffsetPos;

	public bool Computed
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Posef RayPose
	{
		[CompilerGenerated]
		get
		{
			return default(Posef);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool RayValid
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool Pinch
	{
		[CompilerGenerated]
		get
		{
			return false;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float PinchStrength
	{
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}

	private void OnBeforeRender()
	{
	}

	private void UpdateHandJoints()
	{
	}

	private void UpdateAimState()
	{
	}

	private void UpdateRayPose()
	{
	}
}
