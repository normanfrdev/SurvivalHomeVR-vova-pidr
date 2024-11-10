using System;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public struct Frame
	{
		public uint width;

		public uint height;

		public ulong timestamp;

		public uint datasize;

		public IntPtr data;

		public Pose pose;

		public int status;
	}
}
