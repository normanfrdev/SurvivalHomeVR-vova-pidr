using PXR_Audio.Spatializer;
using UnityEngine;

public class PXR_Audio_Spatializer_SceneMaterial : MonoBehaviour
{
	[Tooltip("Acoustic material preset corresponding to real-world material types. Absorption, scattering, and transmission will be automatically set based on the physical nature of the selected material.\nDeviating acoustic parameters away from preset values will automatically set this field to 'Custom'")]
	[SerializeField]
	public AcousticsMaterial materialPreset;

	private AcousticsMaterial lastMaterialPreset;

	[SerializeField]
	[Range(0f, 1f)]
	public float[] absorption;

	[Tooltip("Ratio of sound energy get scattered by each reflection.\n  - Low scattering will result in a more echoic sound\n  - high scattering will result in a more reverberant sound")]
	[SerializeField]
	[Range(0f, 1f)]
	public float scattering;

	[Tooltip("Ratio of sound energy get transmitted through this material.")]
	[SerializeField]
	[Range(0f, 1f)]
	public float transmission;

	private float[] absorptionForValidation;

	private float scatteringForValidation;

	private float transmissionForValidation;

	private static PXR_Audio_Spatializer_Context spatialAudioContextRef;

	private void OnValidate()
	{
	}
}
