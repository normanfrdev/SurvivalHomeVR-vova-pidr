using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VRTemplate
{
	public class Callout : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CEndDelay_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Callout _003C_003E4__this;

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
			public _003CEndDelay_003Ed__12(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CStartDelay_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Callout _003C_003E4__this;

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
			public _003CStartDelay_003Ed__11(int _003C_003E1__state)
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

		[SerializeField]
		[Tooltip("The tooltip Transform associated with this Callout.")]
		private Transform m_LazyTooltip;

		[SerializeField]
		[Tooltip("The line curve GameObject associated with this Callout.")]
		private GameObject m_Curve;

		[SerializeField]
		[Tooltip("The required time to dwell on this callout before the tooltip and curve are enabled.")]
		private float m_DwellTime;

		[SerializeField]
		[Tooltip("Whether the associated tooltip will be unparented on Start.")]
		private bool m_Unparent;

		[SerializeField]
		[Tooltip("Whether the associated tooltip and curve will be disabled on Start.")]
		private bool m_TurnOffAtStart;

		private bool m_Gazing;

		private Coroutine m_StartCo;

		private Coroutine m_EndCo;

		private void Start()
		{
		}

		public void GazeHoverStart()
		{
		}

		public void GazeHoverEnd()
		{
		}

		[IteratorStateMachine(typeof(_003CStartDelay_003Ed__11))]
		private IEnumerator StartDelay()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CEndDelay_003Ed__12))]
		private IEnumerator EndDelay()
		{
			return null;
		}

		private void TurnOnStuff()
		{
		}

		private void TurnOffStuff()
		{
		}
	}
}
