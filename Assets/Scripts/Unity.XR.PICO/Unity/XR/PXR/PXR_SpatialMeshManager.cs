using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PXR
{
	[DisallowMultipleComponent]
	public class PXR_SpatialMeshManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CForeachLoopCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PXR_SpatialMeshManager _003C_003E4__this;

			private int _003CtotalWork_003E5__2;

			private List<PxrSpatialMeshInfo> _003CmeshList_003E5__3;

			private int _003CworkPerFrame_003E5__4;

			private int _003CcurrentIndex_003E5__5;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CForeachLoopCoroutine_003Ed__16(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public GameObject meshPrefab;

		private Dictionary<Guid, GameObject> meshIDToGameobject;

		private Dictionary<Guid, PxrSpatialMeshInfo> spatialMeshNeedingDraw;

		private Mesh mesh;

		private XRMeshSubsystem subsystem;

		private int objectPoolMaxSize;

		private Queue<GameObject> meshObjectsPool;

		public static Action<Guid, GameObject> MeshAdded;

		public static Action<Guid, GameObject> MeshUpdated;

		public static Action<Guid> MeshRemoved;

		private readonly Color[] MeshColor;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void InitializePool()
		{
		}

		private void DrawMesh()
		{
		}

		[IteratorStateMachine(typeof(_003CForeachLoopCoroutine_003Ed__16))]
		private IEnumerator ForeachLoopCoroutine()
		{
			return null;
		}

		private void SpatialMeshDataUpdated(List<PxrSpatialMeshInfo> meshInfos)
		{
		}

		private void CreateMeshRoutine(PxrSpatialMeshInfo block)
		{
		}

		private GameObject CreateGameObject(Guid meshId)
		{
			return null;
		}

		private GameObject GetOrCreateGameObject(Guid meshId)
		{
			return null;
		}
	}
}
