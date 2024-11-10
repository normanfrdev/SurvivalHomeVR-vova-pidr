using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.XR.Oculus
{
	internal class OculusRestarter : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPauseAndRestartCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float pauseTimeInSeconds;

			public OculusRestarter _003C_003E4__this;

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
			public _003CPauseAndRestartCoroutine_003Ed__22(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CRestartCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OculusRestarter _003C_003E4__this;

			public bool shouldRestart;

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
			public _003CRestartCoroutine_003Ed__23(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		internal Action onAfterRestart;

		internal Action onAfterShutdown;

		internal Action onQuit;

		internal Action onAfterCoroutine;

		private static readonly string k_GameObjectName;

		private static OculusRestarter s_Instance;

		private Coroutine m_Coroutine;

		private Coroutine m_pauseAndRestartCoroutine;

		private static int m_pauseAndRestartAttempts;

		public bool isRunning => false;

		public static float TimeBetweenRestartAttempts
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static int PauseAndRestartAttempts => 0;

		public static OculusRestarter Instance => null;

		static OculusRestarter()
		{
		}

		public void ResetCallbacks()
		{
		}

		public void PauseAndRestart()
		{
		}

		[IteratorStateMachine(typeof(_003CPauseAndRestartCoroutine_003Ed__22))]
		public IEnumerator PauseAndRestartCoroutine(float pauseTimeInSeconds)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRestartCoroutine_003Ed__23))]
		private IEnumerator RestartCoroutine(bool shouldRestart)
		{
			return null;
		}
	}
}
