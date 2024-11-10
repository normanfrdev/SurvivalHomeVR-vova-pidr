using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public static class UnityObjectUtility
	{
		[CompilerGenerated]
		private sealed class _003CFindObjectsOfTypeIncludingInactive_003Ed__7<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private int _003Ci_003E5__2;

			private GameObject[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private T[] _003C_003E7__wrap4;

			private int _003C_003E7__wrap5;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CFindObjectsOfTypeIncludingInactive_003Ed__7(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		public static bool IsDestroyed(this UnityEngine.Object target)
		{
			return false;
		}

		public static bool IsUnityNull(this object obj)
		{
			return false;
		}

		public static string ToSafeString(this UnityEngine.Object uo)
		{
			return null;
		}

		public static string ToSafeString(this object obj)
		{
			return null;
		}

		public static T AsUnityNull<T>(this T obj) where T : UnityEngine.Object
		{
			return null;
		}

		public static bool TrulyEqual(UnityEngine.Object a, UnityEngine.Object b)
		{
			return false;
		}

		public static IEnumerable<T> NotUnityNull<T>(this IEnumerable<T> enumerable) where T : UnityEngine.Object
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CFindObjectsOfTypeIncludingInactive_003Ed__7<>))]
		public static IEnumerable<T> FindObjectsOfTypeIncludingInactive<T>()
		{
			return null;
		}
	}
}
