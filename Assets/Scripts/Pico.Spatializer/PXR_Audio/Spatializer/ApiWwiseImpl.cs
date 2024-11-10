using System;
using System.Runtime.InteropServices;

namespace PXR_Audio.Spatializer
{
	public class ApiWwiseImpl : Api
	{
		private const string DLLNAME = "PicoSpatializerWwise";

		[DllImport("PicoSpatializerWwise", EntryPoint = "yggdrasil_get_version")]
		private static extern string GetVersionImport(ref int major, ref int minor, ref int patch);

		public override string GetVersion(ref int major, ref int minor, ref int patch)
		{
			return null;
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_CreateContext")]
		private static extern Result CreateContextImport(ref IntPtr ctx, RenderingMode mode, uint framesPerBuffer, uint sampleRate);

		public override Result CreateContext(ref IntPtr ctx, RenderingMode mode, uint framesPerBuffer, uint sampleRate)
		{
			return default(Result);
		}

		public override Result InitializeContext(IntPtr ctx)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_SubmitMesh")]
		private static extern Result SubmitMeshImport(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, AcousticsMaterial material, ref int geometryId);

		public override Result SubmitMesh(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, AcousticsMaterial material, ref int geometryId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_SubmitMeshAndMaterialFactor")]
		private static extern Result SubmitMeshAndMaterialFactorImport(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, float[] absorptionFactor, float scatteringFactor, float transmissionFactor, ref int geometryId);

		public override Result SubmitMeshAndMaterialFactor(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, float[] absorptionFactor, float scatteringFactor, float transmissionFactor, ref int geometryId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_SubmitMeshWithConfig")]
		private static extern Result SubmitMeshWithConfigImport(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, ref MeshConfig config, ref int geometryId);

		public override Result SubmitMeshWithConfig(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, ref MeshConfig config, ref int geometryId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_RemoveMesh")]
		private static extern Result RemoveMeshImport(IntPtr ctx, int geometryId);

		public override Result RemoveMesh(IntPtr ctx, int geometryId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_SetMeshConfig")]
		private static extern Result SetMeshConfigImport(IntPtr ctx, int geometryId, ref MeshConfig config, uint propertyMask);

		public override Result SetMeshConfig(IntPtr ctx, int geometryId, ref MeshConfig config, uint propertyMask)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_GetAbsorptionFactor")]
		private static extern Result GetAbsorptionFactorImport(AcousticsMaterial material, float[] absorptionFactor);

		public override Result GetAbsorptionFactor(AcousticsMaterial material, float[] absorptionFactor)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_GetScatteringFactor")]
		private static extern Result GetScatteringFactorImport(AcousticsMaterial material, ref float scatteringFactor);

		public override Result GetScatteringFactor(AcousticsMaterial material, ref float scatteringFactor)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_GetTransmissionFactor")]
		private static extern Result GetTransmissionFactorImport(AcousticsMaterial material, ref float transmissionFactor);

		public override Result GetTransmissionFactor(AcousticsMaterial material, ref float transmissionFactor)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_CommitScene")]
		private static extern Result CommitSceneImport(IntPtr ctx);

		public override Result CommitScene(IntPtr ctx)
		{
			return default(Result);
		}

		public override Result AddSource(IntPtr ctx, SourceMode sourceMode, float[] position, ref int sourceId, bool isAsync)
		{
			return default(Result);
		}

		public override Result AddSourceWithOrientation(IntPtr ctx, SourceMode mode, float[] position, float[] front, float[] up, float radius, ref int sourceId, bool isAsync)
		{
			return default(Result);
		}

		public override Result AddSourceWithConfig(IntPtr ctx, ref SourceConfig sourceConfig, ref int sourceId, bool isAsync)
		{
			return default(Result);
		}

		public override Result SetSourceConfig(IntPtr ctx, int sourceId, ref SourceConfig sourceConfig, uint propertyMask)
		{
			return default(Result);
		}

		public override Result SetSourceAttenuationMode(IntPtr ctx, int sourceId, SourceAttenuationMode mode, DistanceAttenuationCallback directDistanceAttenuationCallback, DistanceAttenuationCallback indirectDistanceAttenuationCallback)
		{
			return default(Result);
		}

		public override Result SetSourceRange(IntPtr ctx, int sourceId, float rangeMin, float rangeMax)
		{
			return default(Result);
		}

		public override Result RemoveSource(IntPtr ctx, int sourceId)
		{
			return default(Result);
		}

		public override Result SubmitSourceBuffer(IntPtr ctx, int sourceId, float[] inputBufferPtr, uint numFrames)
		{
			return default(Result);
		}

		public override Result SubmitAmbisonicChannelBuffer(IntPtr ctx, float[] ambisonicChannelBuffer, int order, int degree, AmbisonicNormalizationType normType, float gain)
		{
			return default(Result);
		}

		public override Result SubmitInterleavedAmbisonicBuffer(IntPtr ctx, float[] ambisonicBuffer, int ambisonicOrder, AmbisonicNormalizationType normType, float gain)
		{
			return default(Result);
		}

		public override Result SubmitMatrixInputBuffer(IntPtr ctx, float[] inputBuffer, int inputChannelIndex)
		{
			return default(Result);
		}

		public override Result GetInterleavedBinauralBuffer(IntPtr ctx, float[] outputBufferPtr, uint numFrames, bool isAccumulative)
		{
			return default(Result);
		}

		public override Result GetPlanarBinauralBuffer(IntPtr ctx, float[][] outputBufferPtr, uint numFrames, bool isAccumulative)
		{
			return default(Result);
		}

		public override Result GetInterleavedLoudspeakersBuffer(IntPtr ctx, float[] outputBufferPtr, uint numFrames)
		{
			return default(Result);
		}

		public override Result GetPlanarLoudspeakersBuffer(IntPtr ctx, float[][] outputBufferPtr, uint numFrames)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_UpdateScene")]
		private static extern Result UpdateSceneImport(IntPtr ctx);

		public override Result UpdateScene(IntPtr ctx)
		{
			return default(Result);
		}

		public override Result SetDopplerEffect(IntPtr ctx, int sourceId, bool on)
		{
			return default(Result);
		}

		public override Result SetPlaybackMode(IntPtr ctx, PlaybackMode playbackMode)
		{
			return default(Result);
		}

		public override Result SetLoudspeakerArray(IntPtr ctx, float[] positions, int numLoudspeakers)
		{
			return default(Result);
		}

		public override Result SetMappingMatrix(IntPtr ctx, float[] matrix, int numInputChannels, int numOutputChannels)
		{
			return default(Result);
		}

		public override Result SetListenerPosition(IntPtr ctx, float[] position)
		{
			return default(Result);
		}

		public override Result SetListenerOrientation(IntPtr ctx, float[] front, float[] up)
		{
			return default(Result);
		}

		public override Result SetListenerPose(IntPtr ctx, float[] position, float[] front, float[] up)
		{
			return default(Result);
		}

		public override Result SetSourcePosition(IntPtr ctx, int sourceId, float[] position)
		{
			return default(Result);
		}

		public override Result SetSourceGain(IntPtr ctx, int sourceId, float gain)
		{
			return default(Result);
		}

		public override Result SetSourceSize(IntPtr ctx, int sourceId, float volumetricSize)
		{
			return default(Result);
		}

		public override Result UpdateSourceMode(IntPtr ctx, int sourceId, SourceMode mode)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializerWwise", EntryPoint = "CSharp_PicoSpatializerWwise_Destroy")]
		private static extern Result DestroyImport(IntPtr ctx);

		public override Result Destroy(IntPtr ctx)
		{
			return default(Result);
		}
	}
}
