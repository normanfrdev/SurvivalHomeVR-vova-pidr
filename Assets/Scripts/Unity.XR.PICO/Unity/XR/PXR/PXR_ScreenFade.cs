using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.XR.PXR
{
	public class PXR_ScreenFade : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CScreenFade_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PXR_ScreenFade _003C_003E4__this;

			private float _003CnowTime_003E5__2;

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
			public _003CScreenFade_003Ed__17(int _003C_003E1__state)
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

		[Tooltip("The gradient of time.")]
		public float gradientTime;

		[Tooltip("Basic color.")]
		public Color fadeColor;

		[Tooltip("The default value is 4000.")]
		private int renderQueue;

		private MeshRenderer gradientMeshRenderer;

		private MeshFilter gradientMeshFilter;

		private Material gradientMaterial;

		private bool isGradient;

		private float currentAlpha;

		private float nowFadeAlpha;

		private List<Vector3> verts;

		private List<int> indices;

		private int N;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		private void CreateFadeMesh()
		{
		}

		public void SetCurrentAlpha(float alpha)
		{
		}

		[IteratorStateMachine(typeof(_003CScreenFade_003Ed__17))]
		private IEnumerator ScreenFade()
		{
			return null;
		}

		private void SetAlpha()
		{
		}

		private void CreateModel()
		{
		}

		public void CreateMakePos(int num)
		{
		}

		public void OtherMakePos(int num)
		{
		}

		private void DestoryGradientMesh()
		{
		}
	}
}
