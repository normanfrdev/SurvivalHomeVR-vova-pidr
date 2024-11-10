using Unity.XR.PXR;
using UnityEngine;

public class PXR_ControllerPower : MonoBehaviour
{
	[SerializeField]
	private Texture power1;

	[SerializeField]
	private Texture power2;

	[SerializeField]
	private Texture power3;

	[SerializeField]
	private Texture power4;

	[SerializeField]
	private Texture power5;

	private Material powerMaterial;

	private float interval;

	public PXR_Input.Controller hand;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
