using UnityEngine;

public class PXR_ARCameraEffectManager : MonoBehaviour
{
	public bool enableCameraEffect;

	[HideInInspector]
	public float colortempValue;

	[HideInInspector]
	public float brightnessValue;

	[HideInInspector]
	public float saturationValue;

	[HideInInspector]
	public float contrastValue;

	[HideInInspector]
	public Texture2D lutTex;

	[HideInInspector]
	public float lutRowValue;

	[HideInInspector]
	public float lutColValue;

	private int row;

	private int col;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}
}
