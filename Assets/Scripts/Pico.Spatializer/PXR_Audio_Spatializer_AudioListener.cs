using System.Runtime.InteropServices;
using UnityEngine;

[RequireComponent(typeof(AudioListener))]
public class PXR_Audio_Spatializer_AudioListener : MonoBehaviour
{
	private enum OutputMethod
	{
		OnAudioFilterRead = 0,
		PicoAudioRouter = 1
	}

	[Tooltip("Determine where the output spatial audio signal goes:\n  - On Audio Filter Read: Spatial audio signal got mixed with the rest of the game.\n  - Pico Audio Router: Spatial audio signal got transmitted to one or more 'Pico Audio Router' effects in the Unity Audio Mixer to gain more control to your mix.")]
	[SerializeField]
	private OutputMethod outputMethod;

	private float[] temp_output_buffer;

	private bool isActive;

	private PXR_Audio_Spatializer_Context context;

	private float[] positionArray;

	private float[] frontArray;

	private float[] upArray;

	private bool isAudioDSPInProgress;

	private PXR_Audio_Spatializer_Context Context => null;

	public bool IsAudioDSPInProgress => false;

	internal void RegisterInternal()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void UpdatePose()
	{
	}

	[DllImport("PicoAudioRouter", EntryPoint = "yggdrasil_audio_unity_audio_router_input")]
	private static extern void PicoAudioRouterInput(float[] inBuffer, int inBufferSize, int inChannels);

	private void OnAudioFilterRead(float[] data, int channels)
	{
	}
}
