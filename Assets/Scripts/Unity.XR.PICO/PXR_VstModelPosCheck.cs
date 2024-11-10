using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PXR_VstModelPosCheck : MonoBehaviour
{
	public bool IsController;

	private Transform mMainCamTrans;

	private XRBaseController mXRBaseController;

	private PXR_Hand mPXR_Hand;

	private float mVirtualWorldOffset;

	private readonly Vector3 mStartDirection;

	private Quaternion mHeadRotation;

	private Vector3 mOffsetDirection;

	private Vector3 mOffsetPos;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdatePos()
	{
	}

	private void CheckPos()
	{
	}

	public Vector3 GetHandPosOffset()
	{
		return default(Vector3);
	}
}
