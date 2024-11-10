using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.XR.PXR
{
	public class PXR_MixedReality
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CCreateSpatialAnchorAsync_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(PxrResult result, ulong anchorHandle, Guid uuid)> _003C_003Et__builder;

			public Vector3 position;

			public Quaternion rotation;

			public CancellationToken token;

			private TaskAwaiter<(PxrResult result, ulong anchorHandle, Guid uuid)> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CDownloadSharedSpatialAnchorAsync_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PxrResult> _003C_003Et__builder;

			public Guid uuid;

			public CancellationToken token;

			private TaskAwaiter<PxrResult> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CPersistSpatialAnchorAsync_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PxrResult> _003C_003Et__builder;

			public ulong anchorHandle;

			public CancellationToken token;

			private TaskAwaiter<PxrResult> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CQueryMeshAnchorAsync_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(PxrResult result, List<PxrSpatialMeshInfo> meshInfos)> _003C_003Et__builder;

			public CancellationToken token;

			private TaskAwaiter<(PxrResult, List<PxrSpatialMeshInfo>)> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CQuerySceneAnchorAsync_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(PxrResult result, List<ulong> anchorHandleList)> _003C_003Et__builder;

			public PxrSemanticLabel[] labels;

			public CancellationToken token;

			private TaskAwaiter<(PxrResult result, List<ulong> anchorHandleList)> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CQuerySceneAnchorAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(PxrResult result, Dictionary<ulong, Guid> anchorDictionary)> _003C_003Et__builder;

			public CancellationToken token;

			private TaskAwaiter<(PxrResult result, Dictionary<ulong, Guid> anchorDictionary)> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CQuerySpatialAnchorAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(PxrResult result, List<ulong> anchorHandleList)> _003C_003Et__builder;

			public Guid[] uuids;

			public CancellationToken token;

			private TaskAwaiter<(PxrResult result, List<ulong> anchorHandleList)> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CShareSpatialAnchorAsync_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(PxrResult result, Guid uuid)> _003C_003Et__builder;

			public ulong anchorHandle;

			private TaskAwaiter<(PxrResult result, Guid uuid)> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CStartSceneCaptureAsync_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PxrResult> _003C_003Et__builder;

			public CancellationToken token;

			private TaskAwaiter<PxrResult> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CStartSenseDataProvider_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PxrResult> _003C_003Et__builder;

			public PxrSenseDataProviderType type;

			public CancellationToken token;

			private TaskAwaiter<PxrResult> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CUnPersistSpatialAnchorAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<PxrResult> _003C_003Et__builder;

			public ulong anchorHandle;

			public CancellationToken token;

			private TaskAwaiter<PxrResult> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct _003CUploadSpatialAnchorAsync_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<(PxrResult result, Guid uuid)> _003C_003Et__builder;

			public ulong anchorHandle;

			public CancellationToken token;

			private TaskAwaiter<(PxrResult, Guid)> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		private const string TAG = "[PXR_MixedReality]";

		[AsyncStateMachine(typeof(_003CStartSenseDataProvider_003Ed__1))]
		public static Task<PxrResult> StartSenseDataProvider(PxrSenseDataProviderType type, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		public static PxrResult GetSenseDataProviderState(PxrSenseDataProviderType type, out PxrSenseDataProviderState state)
		{
			state = default(PxrSenseDataProviderState);
			return default(PxrResult);
		}

		public static PxrResult StopSenseDataProvider(PxrSenseDataProviderType type)
		{
			return default(PxrResult);
		}

		[AsyncStateMachine(typeof(_003CCreateSpatialAnchorAsync_003Ed__4))]
		public static Task<(PxrResult result, ulong anchorHandle, Guid uuid)> CreateSpatialAnchorAsync(Vector3 position, Quaternion rotation, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPersistSpatialAnchorAsync_003Ed__5))]
		public static Task<PxrResult> PersistSpatialAnchorAsync(ulong anchorHandle, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUnPersistSpatialAnchorAsync_003Ed__6))]
		public static Task<PxrResult> UnPersistSpatialAnchorAsync(ulong anchorHandle, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		public static PxrResult DestroyAnchor(ulong anchorHandle)
		{
			return default(PxrResult);
		}

		public static PxrResult GetAnchorUuid(ulong anchorHandle, out Guid uuid)
		{
			uuid = default(Guid);
			return default(PxrResult);
		}

		public static PxrResult LocateAnchor(ulong anchorHandle, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			return default(PxrResult);
		}

		[AsyncStateMachine(typeof(_003CQuerySpatialAnchorAsync_003Ed__10))]
		public static Task<(PxrResult result, List<ulong> anchorHandleList)> QuerySpatialAnchorAsync(Guid[] uuids = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CStartSceneCaptureAsync_003Ed__11))]
		public static Task<PxrResult> StartSceneCaptureAsync(CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CQuerySceneAnchorAsync_003Ed__12))]
		public static Task<(PxrResult result, List<ulong> anchorHandleList)> QuerySceneAnchorAsync(PxrSemanticLabel[] labels = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CQuerySceneAnchorAsync_003Ed__13))]
		public static Task<(PxrResult result, Dictionary<ulong, Guid> anchorDictionary)> QuerySceneAnchorAsync(CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		public static PxrResult GetSceneAnchorComponentTypes(ulong anchorHandle, out PxrSceneComponentType[] types)
		{
			types = null;
			return default(PxrResult);
		}

		public static PxrResult GetSceneSemanticLabel(ulong anchorHandle, out PxrSemanticLabel label)
		{
			label = default(PxrSemanticLabel);
			return default(PxrResult);
		}

		public static PxrResult GetSceneBox3DData(ulong anchorHandle, out Vector3 position, out Quaternion rotation, out Vector3 extent)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
			extent = default(Vector3);
			return default(PxrResult);
		}

		public static PxrResult GetSceneBox2DData(ulong anchorHandle, out Vector2 offset, out Vector2 extent)
		{
			offset = default(Vector2);
			extent = default(Vector2);
			return default(PxrResult);
		}

		public static PxrResult GetScenePolygonData(ulong anchorHandle, out Vector2[] vertices)
		{
			vertices = null;
			return default(PxrResult);
		}

		[AsyncStateMachine(typeof(_003CQueryMeshAnchorAsync_003Ed__19))]
		public static Task<(PxrResult result, List<PxrSpatialMeshInfo> meshInfos)> QueryMeshAnchorAsync(CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CUploadSpatialAnchorAsync_003Ed__20))]
		public static Task<(PxrResult result, Guid uuid)> UploadSpatialAnchorAsync(ulong anchorHandle, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CDownloadSharedSpatialAnchorAsync_003Ed__21))]
		public static Task<PxrResult> DownloadSharedSpatialAnchorAsync(Guid uuid, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CShareSpatialAnchorAsync_003Ed__22))]
		[Obsolete("Please use UploadSpatialAnchorAsync")]
		public static Task<(PxrResult result, Guid uuid)> ShareSpatialAnchorAsync(ulong anchorHandle)
		{
			return null;
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult CreateAnchorEntity(Vector3 position, Quaternion rotation, out ulong taskId)
		{
			taskId = default(ulong);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult DestroyAnchorEntity(ulong handle)
		{
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult GetAnchorPose(ulong handle, out Quaternion orientation, out Vector3 position)
		{
			orientation = default(Quaternion);
			position = default(Vector3);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult GetAnchorEntityUuid(ulong handle, out Guid uuid)
		{
			uuid = default(Guid);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult PersistAnchorEntity(ulong[] anchorHandles, PxrPersistLocation location, out ulong taskId)
		{
			taskId = default(ulong);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult UnPersistAnchorEntity(ulong[] anchorHandles, PxrPersistLocation location, out ulong taskId)
		{
			taskId = default(ulong);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult ClearPersistedAnchorEntity(PxrPersistLocation location, out ulong taskId)
		{
			taskId = default(ulong);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult GetAnchorComponentFlags(ulong anchorHandle, out PxrAnchorComponentTypeFlags[] flags)
		{
			flags = null;
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult LoadAnchorEntityByUuidFilter(out ulong taskId, Guid[] uuids = null)
		{
			taskId = default(ulong);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult LoadAnchorEntityBySceneFilter(PxrSpatialSceneDataTypeFlags[] flags, out ulong taskId)
		{
			taskId = default(ulong);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult GetAnchorEntityLoadResults(ulong taskId, uint count, out Dictionary<ulong, Guid> loadedAnchors)
		{
			loadedAnchors = null;
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult StartSpatialSceneCapture(out ulong taskId)
		{
			taskId = default(ulong);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult GetAnchorVolumeInfo(ulong anchorHandle, out Vector3 center, out Vector3 extent)
		{
			center = default(Vector3);
			extent = default(Vector3);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult GetAnchorPlanePolygonInfo(ulong anchorHandle, out Vector3[] vertices)
		{
			vertices = null;
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult GetAnchorPlaneBoundaryInfo(ulong anchorHandle, out Vector3 center, out Vector2 extent)
		{
			center = default(Vector3);
			extent = default(Vector2);
			return default(PxrResult);
		}

		[Obsolete("Deprecated.Only Support PICO 4.")]
		public static PxrResult GetAnchorSceneLabel(ulong anchorHandle, out PxrSceneLabel label)
		{
			label = default(PxrSceneLabel);
			return default(PxrResult);
		}

		public static int EnableVideoSeeThrough(bool state)
		{
			return 0;
		}

		public static int EnableVideoSeeThroughEffect(bool value)
		{
			return 0;
		}

		public static int SetVideoSeeThroughEffect(PxrLayerEffect type, float value, float duration)
		{
			return 0;
		}

		public static int SetVideoSeeThroughLut(Texture2D texture, int row, int col)
		{
			return 0;
		}
	}
}
