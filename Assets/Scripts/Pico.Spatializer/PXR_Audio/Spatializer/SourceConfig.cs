using System;
using System.Runtime.InteropServices;

namespace PXR_Audio.Spatializer
{
	public struct SourceConfig
	{
		[MarshalAs(UnmanagedType.U4)]
		public SourceMode mode;

		public NativeVector3f position;

		public NativeVector3f front;

		public NativeVector3f up;

		public float directivityAlpha;

		public float directivityOrder;

		public float radius;

		[MarshalAs(UnmanagedType.U1)]
		public bool useDirectPathSpread;

		public float directPathSpread;

		public float sourceGain;

		public float reflectionGain;

		[MarshalAs(UnmanagedType.U1)]
		public bool enableDoppler;

		[MarshalAs(UnmanagedType.U4)]
		public SourceAttenuationMode attenuationMode;

		public IntPtr directDistanceAttenuationCallback;

		public IntPtr indirectDistanceAttenuationCallback;

		public float minAttenuationDistance;

		public float maxAttenuationDistance;

		public SourceConfig(SourceMode inMode)
		{
		}
	}
}
