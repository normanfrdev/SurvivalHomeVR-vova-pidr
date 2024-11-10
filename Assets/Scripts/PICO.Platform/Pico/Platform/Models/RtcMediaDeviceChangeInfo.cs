using System;

namespace Pico.Platform.Models
{
	public class RtcMediaDeviceChangeInfo
	{
		public readonly string DeviceId;

		public readonly RtcMediaDeviceType DeviceType;

		public readonly RtcMediaDeviceState DeviceState;

		public readonly RtcMediaDeviceError DeviceError;

		public RtcMediaDeviceChangeInfo(IntPtr o)
		{
		}
	}
}
