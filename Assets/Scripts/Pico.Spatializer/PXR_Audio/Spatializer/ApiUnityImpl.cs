using System;
using System.Runtime.InteropServices;

namespace PXR_Audio.Spatializer
{
	public class ApiUnityImpl : Api
	{
		private const string DLLNAME = "PicoSpatializer";

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_get_version")]
		private static extern string GetVersionImport(ref int major, ref int minor, ref int patch);

		public override string GetVersion(ref int major, ref int minor, ref int patch)
		{
			return null;
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_create_context")]
		private static extern Result CreateContextImport(ref IntPtr ctx, RenderingMode mode, uint framesPerBuffer, uint sampleRate);

		public override Result CreateContext(ref IntPtr ctx, RenderingMode mode, uint framesPerBuffer, uint sampleRate)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_initialize_context")]
		private static extern Result InitializeContextImport(IntPtr ctx);

		public override Result InitializeContext(IntPtr ctx)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_submit_mesh")]
		private static extern Result SubmitMeshImport(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, AcousticsMaterial material, ref int geometryId);

		public override Result SubmitMesh(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, AcousticsMaterial material, ref int geometryId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_submit_mesh_and_material_factor")]
		private static extern Result SubmitMeshAndMaterialFactorImport(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, float[] absorptionFactor, float scatteringFactor, float transmissionFactor, ref int geometryId);

		public override Result SubmitMeshAndMaterialFactor(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, float[] absorptionFactor, float scatteringFactor, float transmissionFactor, ref int geometryId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_submit_mesh_with_config")]
		private static extern Result SubmitMeshWithConfigImport(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, ref MeshConfig config, ref int geometryId);

		public override Result SubmitMeshWithConfig(IntPtr ctx, float[] vertices, int verticesCount, int[] indices, int indicesCount, ref MeshConfig config, ref int geometryId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_remove_mesh")]
		private static extern Result RemoveMeshImport(IntPtr ctx, int geometryId);

		public override Result RemoveMesh(IntPtr ctx, int geometryId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_mesh_config")]
		private static extern Result SetMeshConfigImport(IntPtr ctx, int geometryId, ref MeshConfig config, uint propertyMask);

		public override Result SetMeshConfig(IntPtr ctx, int geometryId, ref MeshConfig config, uint propertyMask)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_get_absorption_factor")]
		private static extern Result GetAbsorptionFactorImport(AcousticsMaterial material, float[] absorptionFactor);

		public override Result GetAbsorptionFactor(AcousticsMaterial material, float[] absorptionFactor)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_get_scattering_factor")]
		private static extern Result GetScatteringFactorImport(AcousticsMaterial material, ref float scatteringFactor);

		public override Result GetScatteringFactor(AcousticsMaterial material, ref float scatteringFactor)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_get_transmission_factor")]
		private static extern Result GetTransmissionFactorImport(AcousticsMaterial material, ref float transmissionFactor);

		public override Result GetTransmissionFactor(AcousticsMaterial material, ref float transmissionFactor)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_commit_scene")]
		private static extern Result CommitSceneImport(IntPtr ctx);

		public override Result CommitScene(IntPtr ctx)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_add_source")]
		private static extern Result AddSourceImport(IntPtr ctx, SourceMode sourceMode, float[] position, ref int sourceId, bool isAsync);

		public override Result AddSource(IntPtr ctx, SourceMode sourceMode, float[] position, ref int sourceId, bool isAsync)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_add_source_with_orientation")]
		private static extern Result AddSourceWithOrientationImport(IntPtr ctx, SourceMode mode, float[] position, float[] front, float[] up, float radius, ref int sourceId, bool isAsync);

		public override Result AddSourceWithOrientation(IntPtr ctx, SourceMode mode, float[] position, float[] front, float[] up, float radius, ref int sourceId, bool isAsync)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_add_source_with_config")]
		private static extern Result AddSourceWithConfigImport(IntPtr ctx, ref SourceConfig sourceConfig, ref int sourceId, bool isAsync);

		public override Result AddSourceWithConfig(IntPtr ctx, ref SourceConfig sourceConfig, ref int sourceId, bool isAsync)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_source_config")]
		private static extern Result SetSourceConfigImport(IntPtr ctx, int sourceId, ref SourceConfig sourceConfig, uint propertyMask);

		public override Result SetSourceConfig(IntPtr ctx, int sourceId, ref SourceConfig sourceConfig, uint propertyMask)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_source_attenuation_mode")]
		private static extern Result SetSourceAttenuationModeImport(IntPtr ctx, int sourceId, SourceAttenuationMode mode, DistanceAttenuationCallback directDistanceAttenuationCallback, DistanceAttenuationCallback indirectDistanceAttenuationCallback);

		public override Result SetSourceAttenuationMode(IntPtr ctx, int sourceId, SourceAttenuationMode mode, DistanceAttenuationCallback directDistanceAttenuationCallback, DistanceAttenuationCallback indirectDistanceAttenuationCallback)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_source_range")]
		private static extern Result SetSourceRangeImport(IntPtr ctx, int sourceId, float rangeMin, float rangeMax);

		public override Result SetSourceRange(IntPtr ctx, int sourceId, float rangeMin, float rangeMax)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_remove_source")]
		private static extern Result RemoveSourceImport(IntPtr ctx, int sourceId, bool is_async);

		public override Result RemoveSource(IntPtr ctx, int sourceId)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_submit_source_buffer")]
		private static extern Result SubmitSourceBufferImport(IntPtr ctx, int sourceId, float[] inputBufferPtr, uint numFrames);

		public override Result SubmitSourceBuffer(IntPtr ctx, int sourceId, float[] inputBufferPtr, uint numFrames)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_submit_ambisonic_channel_buffer")]
		private static extern Result SubmitAmbisonicChannelBufferImport(IntPtr ctx, float[] ambisonicChannelBuffer, int order, int degree, AmbisonicNormalizationType normType, float gain);

		public override Result SubmitAmbisonicChannelBuffer(IntPtr ctx, float[] ambisonicChannelBuffer, int order, int degree, AmbisonicNormalizationType normType, float gain)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_submit_interleaved_ambisonic_buffer")]
		private static extern Result SubmitInterleavedAmbisonicBufferImport(IntPtr ctx, float[] ambisonicBuffer, int ambisonicOrder, AmbisonicNormalizationType normType, float gain);

		public override Result SubmitInterleavedAmbisonicBuffer(IntPtr ctx, float[] ambisonicBuffer, int ambisonicOrder, AmbisonicNormalizationType normType, float gain)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_submit_matrix_input_buffer")]
		private static extern Result SubmitMatrixInputBufferImport(IntPtr ctx, float[] inputBuffer, int inputChannelIndex);

		public override Result SubmitMatrixInputBuffer(IntPtr ctx, float[] inputBuffer, int inputChannelIndex)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_get_interleaved_binaural_buffer")]
		private static extern Result GetInterleavedBinauralBufferImport(IntPtr ctx, float[] outputBufferPtr, uint numFrames, bool isAccumulative);

		public override Result GetInterleavedBinauralBuffer(IntPtr ctx, float[] outputBufferPtr, uint numFrames, bool isAccumulative)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_get_planar_binaural_buffer")]
		private static extern Result GetPlanarBinauralBufferImport(IntPtr ctx, float[][] outputBufferPtr, uint numFrames, bool isAccumulative);

		public override Result GetPlanarBinauralBuffer(IntPtr ctx, float[][] outputBufferPtr, uint numFrames, bool isAccumulative)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_get_interleaved_loudspeakers_buffer")]
		private static extern Result GetInterleavedLoudspeakersBufferImport(IntPtr ctx, float[] outputBufferPtr, uint numFrames);

		public override Result GetInterleavedLoudspeakersBuffer(IntPtr ctx, float[] outputBufferPtr, uint numFrames)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_get_planar_loudspeakers_buffer")]
		private static extern Result GetPlanarLoudspeakersBufferImport(IntPtr ctx, float[][] outputBufferPtr, uint numFrames);

		public override Result GetPlanarLoudspeakersBuffer(IntPtr ctx, float[][] outputBufferPtr, uint numFrames)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_update_scene")]
		private static extern Result UpdateSceneImport(IntPtr ctx);

		public override Result UpdateScene(IntPtr ctx)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_doppler_effect")]
		private static extern Result SetDopplerEffectImport(IntPtr ctx, int sourceId, bool on);

		public override Result SetDopplerEffect(IntPtr ctx, int sourceId, bool on)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_playback_mode")]
		private static extern Result SetPlaybackModeImport(IntPtr ctx, PlaybackMode playbackMode);

		public override Result SetPlaybackMode(IntPtr ctx, PlaybackMode playbackMode)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_loudspeaker_array")]
		private static extern Result SetLoudspeakerArrayImport(IntPtr ctx, float[] positions, int numLoudspeakers);

		public override Result SetLoudspeakerArray(IntPtr ctx, float[] positions, int numLoudspeakers)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_mapping_matrix")]
		private static extern Result SetMappingMatrixImport(IntPtr ctx, float[] matrix, int numInputChannels, int numOutputChannels);

		public override Result SetMappingMatrix(IntPtr ctx, float[] matrix, int numInputChannels, int numOutputChannels)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_listener_position")]
		private static extern Result SetListenerPositionImport(IntPtr ctx, float[] position);

		public override Result SetListenerPosition(IntPtr ctx, float[] position)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_listener_orientation")]
		private static extern Result SetListenerOrientationImport(IntPtr ctx, float[] front, float[] up);

		public override Result SetListenerOrientation(IntPtr ctx, float[] front, float[] up)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_listener_pose")]
		private static extern Result SetListenerPoseImport(IntPtr ctx, float[] position, float[] front, float[] up);

		public override Result SetListenerPose(IntPtr ctx, float[] position, float[] front, float[] up)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_source_position")]
		private static extern Result SetSourcePositionImport(IntPtr ctx, int sourceId, float[] position);

		public override Result SetSourcePosition(IntPtr ctx, int sourceId, float[] position)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_source_gain")]
		private static extern Result SetSourceGainImport(IntPtr ctx, int sourceId, float gain);

		public override Result SetSourceGain(IntPtr ctx, int sourceId, float gain)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_set_source_size")]
		private static extern Result SetSourceSizeImport(IntPtr ctx, int sourceId, float volumetricSize);

		public override Result SetSourceSize(IntPtr ctx, int sourceId, float volumetricSize)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_update_source_mode")]
		private static extern Result UpdateSourceModeImport(IntPtr ctx, int sourceId, SourceMode mode);

		public override Result UpdateSourceMode(IntPtr ctx, int sourceId, SourceMode mode)
		{
			return default(Result);
		}

		[DllImport("PicoSpatializer", EntryPoint = "yggdrasil_audio_destroy")]
		private static extern Result DestroyImport(IntPtr ctx);

		public override Result Destroy(IntPtr ctx)
		{
			return default(Result);
		}

		[DllImport("PicoAmbisonicDecoder", EntryPoint = "yggdrasil_audio_unity_ambisonic_decoder_update")]
		private static extern void AmbisonicDecoderUpdate();
	}
}
