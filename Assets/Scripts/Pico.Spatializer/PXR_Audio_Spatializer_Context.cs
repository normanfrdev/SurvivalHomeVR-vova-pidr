using System;
using PXR_Audio.Spatializer;
using UnityEngine;
using UnityEngine.Events;

public class PXR_Audio_Spatializer_Context : MonoBehaviour
{
	[Tooltip("Audio backend you prefer to use")]
	[SerializeField]
	public SpatializerApiImpl spatializerApiImpl;

	private static Api _api;

	private static PXR_Audio_Spatializer_Context _instance;

	private IntPtr context;

	private bool initialized;

	private bool isSceneDirty;

	[Tooltip("Rendering quality for Pico Spatial Audio system. Higher quality gives you better accuracy to real world, while lower quality saves you more computation.\n  - You need to re-enable this component after your changed quality during runtime.")]
	[SerializeField]
	private RenderingMode renderingQuality;

	[Tooltip("Customizable event executed right before Pico Spatial Audio system is initialized for this game.")]
	[SerializeField]
	private UnityEvent preInitEvent;

	[Tooltip("Customizable event executed right after Pico Spatial Audio system is initialized for this game.")]
	[SerializeField]
	private UnityEvent lateInitEvent;

	private AudioConfiguration audioConfig;

	private bool bypass;

	private static int uuidCounter;

	private int uuid;

	public Api PXR_Audio_Spatializer_Api => null;

	public static PXR_Audio_Spatializer_Context Instance => null;

	public bool Initialized => false;

	public RenderingMode RenderingQuality => default(RenderingMode);

	public AudioConfiguration AudioConfig => default(AudioConfiguration);

	private bool Bypass => false;

	public int UUID => 0;

	private static int GetUuid()
	{
		return 0;
	}

	public Result SubmitMesh(float[] vertices, int verticesCount, int[] indices, int indicesCount, AcousticsMaterial material, ref int geometryId)
	{
		return default(Result);
	}

	public Result SubmitMeshAndMaterialFactor(float[] vertices, int verticesCount, int[] indices, int indicesCount, float[] absorptionFactor, float scatteringFactor, float transmissionFactor, ref int geometryId)
	{
		return default(Result);
	}

	public Result SubmitMeshWithConfig(float[] vertices, int verticesCount, int[] indices, int indicesCount, ref MeshConfig config, ref int geometryId)
	{
		return default(Result);
	}

	public Result RemoveMesh(int geometryId)
	{
		return default(Result);
	}

	public Result SetMeshConfig(int geometryId, ref MeshConfig config, uint propertyMask)
	{
		return default(Result);
	}

	public Result AddSource(SourceMode sourceMode, float[] position, ref int sourceId, bool isAsync = false)
	{
		return default(Result);
	}

	public Result AddSourceWithOrientation(SourceMode mode, float[] position, float[] front, float[] up, float radius, ref int sourceId, bool isAsync)
	{
		return default(Result);
	}

	public Result AddSourceWithConfig(ref SourceConfig sourceConfig, ref int sourceId, bool isAsync)
	{
		return default(Result);
	}

	public Result SetSourceConfig(int sourceId, ref SourceConfig sourceConfig, uint propertyMask)
	{
		return default(Result);
	}

	public Result SetSourceAttenuationMode(int sourceId, SourceAttenuationMode mode, DistanceAttenuationCallback directDistanceAttenuationCallback = null, DistanceAttenuationCallback indirectDistanceAttenuationCallback = null)
	{
		return default(Result);
	}

	public Result SetSourceRange(int sourceId, float rangeMin, float rangeMax)
	{
		return default(Result);
	}

	public Result RemoveSource(int sourceId)
	{
		return default(Result);
	}

	public Result SubmitSourceBuffer(int sourceId, float[] inputBufferPtr, uint numFrames)
	{
		return default(Result);
	}

	public Result SubmitAmbisonicChannelBuffer(float[] ambisonicChannelBuffer, int order, int degree, AmbisonicNormalizationType normType, float gain)
	{
		return default(Result);
	}

	public Result SubmitInterleavedAmbisonicBuffer(float[] ambisonicBuffer, int ambisonicOrder, AmbisonicNormalizationType normType, float gain)
	{
		return default(Result);
	}

	public Result SubmitMatrixInputBuffer(float[] inputBuffer, int inputChannelIndex)
	{
		return default(Result);
	}

	public Result GetInterleavedBinauralBuffer(float[] outputBufferPtr, uint numFrames, bool isAccumulative)
	{
		return default(Result);
	}

	public Result GetPlanarBinauralBuffer(float[][] outputBufferPtr, uint numFrames, bool isAccumulative)
	{
		return default(Result);
	}

	public Result GetInterleavedLoudspeakersBuffer(float[] outputBufferPtr, uint numFrames)
	{
		return default(Result);
	}

	public Result GetPlanarLoudspeakersBuffer(float[][] outputBufferPtr, uint numFrames)
	{
		return default(Result);
	}

	public Result SetPlaybackMode(PlaybackMode playbackMode)
	{
		return default(Result);
	}

	public Result SetLoudspeakerArray(float[] positions, int numLoudspeakers)
	{
		return default(Result);
	}

	public Result SetMappingMatrix(float[] matrix, int numInputChannels, int numOutputChannels)
	{
		return default(Result);
	}

	public Result SetListenerPosition(float[] position)
	{
		return default(Result);
	}

	public Result SetListenerOrientation(float[] front, float[] up)
	{
		return default(Result);
	}

	public Result SetListenerPose(float[] position, float[] front, float[] up)
	{
		return default(Result);
	}

	public Result SetSourcePosition(int sourceId, float[] position)
	{
		return default(Result);
	}

	public Result SetSourceGain(int sourceId, float gain)
	{
		return default(Result);
	}

	public Result SetSourceSize(int sourceId, float volumetricSize)
	{
		return default(Result);
	}

	public Result UpdateSourceMode(int sourceId, SourceMode mode)
	{
		return default(Result);
	}

	public Result SetDopplerEffect(int sourceId, bool on)
	{
		return default(Result);
	}

	private void OnAudioConfigurationChangedEventHandler(bool deviceWasChanged)
	{
	}

	public void SetRenderingQuality(RenderingMode quality)
	{
	}

	private void OnEnable()
	{
	}

	private void StartInternal(RenderingMode quality)
	{
	}

	private void DestroyInternal()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void ResetContext(RenderingMode quality)
	{
	}
}
