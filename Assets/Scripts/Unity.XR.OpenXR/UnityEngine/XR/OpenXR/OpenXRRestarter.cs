using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.OpenXR
{
	internal class OpenXRRestarter : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPauseAndRetryInitializationCoroutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OpenXRRestarter _003C_003E4__this;

			public float pauseTimeInSeconds;

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
			public _003CPauseAndRetryInitializationCoroutine_003Ed__35(int _003C_003E1__state)
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
		private sealed class _003CPauseAndShutdownAndRestartCoroutine_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public OpenXRRestarter _003C_003E4__this;

			public float pauseTimeInSeconds;

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
			public _003CPauseAndShutdownAndRestartCoroutine_003Ed__34(int _003C_003E1__state)
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
		private sealed class _003CRestartCoroutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public bool shouldShutdown;

			public OpenXRRestarter _003C_003E4__this;

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
			public _003CRestartCoroutine_003Ed__36(int _003C_003E1__state)
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

		internal Action onAfterSuccessfulRestart;

		private static OpenXRRestarter s_Instance;

		private Coroutine m_Coroutine;

		private static int m_pauseAndRestartCoroutineCount;

		private Object m_PauseAndRestartCoroutineCountLock;

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

		internal static int PauseAndRestartCoroutineCount => 0;

		public static OpenXRRestarter Instance => null;

		internal static bool DisableApplicationQuit
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		static OpenXRRestarter()
		{
		}

		public void ResetCallbacks()
		{
		}

		public void Shutdown()
		{
		}

		public void ShutdownAndRestart()
		{
		}

		public void PauseAndShutdownAndRestart()
		{
		}

		public void PauseAndRetryInitialization()
		{
		}

		private void IncrementPauseAndRestartCoroutineCount()
		{
		}

		private void DecrementPauseAndRestartCoroutineCount()
		{
		}

		[IteratorStateMachine(typeof(_003CPauseAndShutdownAndRestartCoroutine_003Ed__34))]
		private IEnumerator PauseAndShutdownAndRestartCoroutine(float pauseTimeInSeconds)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPauseAndRetryInitializationCoroutine_003Ed__35))]
		private IEnumerator PauseAndRetryInitializationCoroutine(float pauseTimeInSeconds)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CRestartCoroutine_003Ed__36))]
		private IEnumerator RestartCoroutine(bool shouldRestart, bool shouldShutdown)
		{
			return null;
		}
	}
}
