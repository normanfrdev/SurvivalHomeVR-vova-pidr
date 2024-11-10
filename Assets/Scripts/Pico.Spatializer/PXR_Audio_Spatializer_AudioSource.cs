using PXR_Audio.Spatializer;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PXR_Audio_Spatializer_AudioSource : MonoBehaviour
{
	[SerializeField]
	[Range(0f, 24f)]
	private float sourceGainDB;

	private float sourceGainAmplitude;

	[SerializeField]
	[Range(-120f, 48f)]
	private float reflectionGainDB;

	private float reflectionGainAmplitude;

	[SerializeField]
	[Range(0f, 100000f)]
	private float sourceSize;

	[Tooltip("Whether Pico Doppler Simulation is enabled for this sound source, which affects both direct and reflection path of it.\n  - If you disabled this option before run or build, you cannot turn it on during runtime, since doppler effect unit is not initialized to save memory.")]
	[SerializeField]
	private bool enableDoppler;

	[Tooltip("Mode of distance attenuation of this sound source.\n  - None && Fixed: Source volume doesn't decrease when source-listener distance increases.\n  - Inversed Squared: Source volume decrease when source-listener distance increases, just like the real world.\n  - Customized: Don't use it!!!!")]
	[SerializeField]
	public SourceAttenuationMode sourceAttenuationMode;

	[Tooltip("Source volume will not further increase when source-listener distance is less than this.\n  - Only effective when source attenuation mode == Inversed Squared")]
	[SerializeField]
	public float minAttenuationDistance;

	[Tooltip("Source volume will not further decrease when source-listener distance is more than this.\n  - Only effective when source attenuation mode == Inversed Squared")]
	[SerializeField]
	public float maxAttenuationDistance;

	[Tooltip("Determine shape of the radiation polar pattern of this sound source.\n  - Alpha = 0 gives you omnidirectional polar pattern\n  - Alpha = 0.5 gives you cardioid polar pattern\n  - Alpha = 1 gives you figure-8 polar pattern")]
	[SerializeField]
	[Range(0f, 1f)]
	private float directivityAlpha;

	[Tooltip("Determine width of the radiation polar pattern of this sound source.\n  - Larger order gives you narrower radiation pattern.")]
	[SerializeField]
	[Range(0f, 1000f)]
	private float directivityOrder;

	private SourceConfig sourceConfig;

	private uint sourcePropertyMask;

	private bool isActive;

	private bool isAudioDSPInProgress;

	private PXR_Audio_Spatializer_Context context;

	private AudioSource nativeSource;

	private int sourceId;

	private int currentContextUuid;

	private float[] positionArray;

	private float playheadPosition;

	private bool wasPlaying;

	public bool IsAudioDSPInProgress => false;

	private PXR_Audio_Spatializer_Context Context => null;

	private void OnEnable()
	{
	}

	internal void RegisterInternal()
	{
	}

	public void Resume()
	{
	}

	public void SetGainDB(float gainDB)
	{
	}

	public float GetGainDB()
	{
		return 0f;
	}

	public void SetGainAmplitude(float gainAmplitude)
	{
	}

	public void SetReflectionGainDB(float gainDB)
	{
	}

	public float GetReflectionGainDB()
	{
		return 0f;
	}

	public void SetSize(float radius)
	{
	}

	public float GetSize()
	{
		return 0f;
	}

	public void SetDopplerStatus(bool on)
	{
	}

	public bool GetDopplerStatus()
	{
		return false;
	}

	public SourceAttenuationMode GetAttenuationMode()
	{
		return default(SourceAttenuationMode);
	}

	public void SetMinAttenuationRange(float min)
	{
	}

	public float GetMinAttenuationRange()
	{
		return 0f;
	}

	public void SetMaxAttenuationRange(float max)
	{
	}

	public float GetMaxAttenuationRange()
	{
		return 0f;
	}

	public void SetDirectivity(float alpha, float order)
	{
	}

	public float GetDirectivityAlpha()
	{
		return 0f;
	}

	public float GetDirectivityOrder()
	{
		return 0f;
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void DestroyInternal()
	{
	}

	private void OnAudioFilterRead(float[] data, int channels)
	{
	}

	private float DB2Mag(float db)
	{
		return 0f;
	}

	private float Mag2DB(float mag)
	{
		return 0f;
	}

	private void OnDrawGizmos()
	{
	}
}
