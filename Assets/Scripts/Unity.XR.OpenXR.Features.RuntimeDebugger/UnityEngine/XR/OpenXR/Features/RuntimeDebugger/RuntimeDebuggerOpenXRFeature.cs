using System;
using System.Runtime.InteropServices;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.XR.OpenXR.Features.RuntimeDebugger
{
	public class RuntimeDebuggerOpenXRFeature : OpenXRFeature
	{
		internal static readonly Guid kEditorToPlayerRequestDebuggerOutput;

		internal static readonly Guid kPlayerToEditorSendDebuggerOutput;

		public uint cacheSize;

		public uint perThreadCacheSize;

		private uint lutOffset;

		private const string Library = "openxr_runtime_debugger";

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return (IntPtr)0;
		}

		internal void RecvMsg(MessageEventArgs args)
		{
		}

		[DllImport("openxr_runtime_debugger", EntryPoint = "HookXrInstanceProcAddr")]
		private static extern IntPtr Native_HookGetInstanceProcAddr(IntPtr func, uint cacheSize, uint perThreadCacheSize);

		[DllImport("openxr_runtime_debugger", EntryPoint = "GetDataForRead")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Native_GetDataForRead(out IntPtr ptr, out uint size);

		[DllImport("openxr_runtime_debugger", EntryPoint = "GetLUTData")]
		private static extern void Native_GetLUTData(out IntPtr ptr, out uint size, uint offset);

		[DllImport("openxr_runtime_debugger", EntryPoint = "StartDataAccess")]
		private static extern void Native_StartDataAccess();

		[DllImport("openxr_runtime_debugger", EntryPoint = "EndDataAccess")]
		private static extern void Native_EndDataAccess();
	}
}
