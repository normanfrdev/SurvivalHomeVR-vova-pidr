using System;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Collections
{
	public struct NativeCurve : IDisposable
	{
		private NativeArray<float> m_Values;

		private WrapMode m_PreWrapMode;

		private WrapMode m_PostWrapMode;

		public bool isCreated => false;

		private void InitializeValues(int count, Allocator allocator = Allocator.Persistent)
		{
		}

		public void Update(AnimationCurve curve, int resolution)
		{
		}

		public float Evaluate(float t)
		{
			return 0f;
		}

		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private float Repeat(float t, float length)
		{
			return 0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private float PingPong(float t, float length)
		{
			return 0f;
		}
	}
}
