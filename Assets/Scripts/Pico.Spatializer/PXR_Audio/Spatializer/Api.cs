using System;

namespace PXR_Audio.Spatializer
{
	public abstract class Api
	{
		public abstract string GetVersion(ref int major, ref int minor, ref int patch);

		public abstract Result CreateContext(ref IntPtr ctx, RenderingMode mode, uint framesPerBuffer, uint sampleRate);

		public abstract Result InitializeContext(IntPtr ctx);

		public abstract Result SubmitMesh(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, AcousticsMaterial material, ref int geometryId);

		public abstract Result SubmitMeshAndMaterialFactor(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, float[] absorptionFactor, float scatteringFactor, float transmissionFactor, ref int geometryId);

		public abstract Result SubmitMeshWithConfig(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, ref MeshConfig config, ref int geometryId);

		public abstract Result RemoveMesh(IntPtr ctx, int geometryId);

		public abstract Result SetMeshConfig(IntPtr ctx, int geometryId, ref MeshConfig config, uint propertyMask);

		public abstract Result GetAbsorptionFactor(AcousticsMaterial material, float[] absorptionFactor);

		public abstract Result GetScatteringFactor(AcousticsMaterial material, ref float scatteringFactor);

		public abstract Result GetTransmissionFactor(AcousticsMaterial material, ref float transmissionFactor);

		public abstract Result CommitScene(IntPtr ctx);

		public abstract Result AddSource(IntPtr ctx, SourceMode sourceMode, float[] position, ref int sourceId, bool isAsync);

		public abstract Result AddSourceWithOrientation(IntPtr ctx, SourceMode mode, float[] position, float[] front, float[] up, float radius, ref int sourceId, bool isAsync);

		public abstract Result AddSourceWithConfig(IntPtr ctx, ref SourceConfig sourceConfig, ref int sourceId, bool isAsync);

		public abstract Result SetSourceConfig(IntPtr ctx, int sourceId, ref SourceConfig sourceConfig, uint propertyMask);

		public abstract Result SetSourceAttenuationMode(IntPtr ctx, int sourceId, SourceAttenuationMode mode, DistanceAttenuationCallback directDistanceAttenuationCallback, DistanceAttenuationCallback indirectDistanceAttenuationCallback);

		public abstract Result SetSourceRange(IntPtr ctx, int sourceId, float rangeMin, float rangeMax);

		public abstract Result RemoveSource(IntPtr ctx, int sourceId);

		public abstract Result SubmitSourceBuffer(IntPtr ctx, int sourceId, float[] inputBufferPtr, uint numFrames);

		public abstract Result SubmitAmbisonicChannelBuffer(IntPtr ctx, float[] ambisonicChannelBuffer, int order, int degree, AmbisonicNormalizationType normType, float gain);

		public abstract Result SubmitInterleavedAmbisonicBuffer(IntPtr ctx, float[] ambisonicBuffer, int ambisonicOrder, AmbisonicNormalizationType normType, float gain);

		public abstract Result SubmitMatrixInputBuffer(IntPtr ctx, float[] inputBuffer, int inputChannelIndex);

		public abstract Result GetInterleavedBinauralBuffer(IntPtr ctx, float[] outputBufferPtr, uint numFrames, bool isAccumulative);

		public abstract Result GetPlanarBinauralBuffer(IntPtr ctx, float[][] outputBufferPtr, uint numFrames, bool isAccumulative);

		public abstract Result GetInterleavedLoudspeakersBuffer(IntPtr ctx, float[] outputBufferPtr, uint numFrames);

		public abstract Result GetPlanarLoudspeakersBuffer(IntPtr ctx, float[][] outputBufferPtr, uint numFrames);

		public abstract Result UpdateScene(IntPtr ctx);

		public abstract Result SetDopplerEffect(IntPtr ctx, int sourceId, bool on);

		public abstract Result SetPlaybackMode(IntPtr ctx, PlaybackMode playbackMode);

		public abstract Result SetLoudspeakerArray(IntPtr ctx, float[] positions, int numLoudspeakers);

		public abstract Result SetMappingMatrix(IntPtr ctx, float[] matrix, int numInputChannels, int numOutputChannels);

		public abstract Result SetListenerPosition(IntPtr ctx, float[] position);

		public abstract Result SetListenerOrientation(IntPtr ctx, float[] front, float[] up);

		public abstract Result SetListenerPose(IntPtr ctx, float[] position, float[] front, float[] up);

		public abstract Result SetSourcePosition(IntPtr ctx, int sourceId, float[] position);

		public abstract Result SetSourceGain(IntPtr ctx, int sourceId, float gain);

		public abstract Result SetSourceSize(IntPtr ctx, int sourceId, float volumetricSize);

		public abstract Result UpdateSourceMode(IntPtr ctx, int sourceId, SourceMode mode);

		public abstract Result Destroy(IntPtr ctx);
	}
}
