using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils.Bindings.Variables;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class TweenableVariableBase<T> : BindableVariable<T> where T : IEquatable<T>
	{
		[CompilerGenerated]
		private sealed class _003CPlaySequence_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TweenableVariableBase<T> _003C_003E4__this;

			public float duration;

			public T start;

			public T finish;

			public Action onComplete;

			private float _003CtimeElapsed_003E5__2;

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
			public _003CPlaySequence_003Ed__16(int _003C_003E1__state)
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
		private sealed class _003CStartAutoTween_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TweenableVariableBase<T> _003C_003E4__this;

			public float deltaTimeMultiplier;

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
			public _003CStartAutoTween_003Ed__15(int _003C_003E1__state)
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

		protected const float k_NearlyOne = 0.99999f;

		private AnimationCurve m_AnimationCurve;

		private T m_Target;

		public AnimationCurve animationCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public T target
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T initialValue
		{
			[CompilerGenerated]
			get
			{
				return default(T);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void HandleTween(float tweenTarget)
		{
		}

		protected abstract void ExecuteTween(T startValue, T targetValue, float tweenAmount, bool useCurve = false);

		[IteratorStateMachine(typeof(TweenableVariableBase<>._003CStartAutoTween_003Ed__15))]
		public IEnumerator StartAutoTween(float deltaTimeMultiplier)
		{
			return null;
		}

		[IteratorStateMachine(typeof(TweenableVariableBase<>._003CPlaySequence_003Ed__16))]
		public IEnumerator PlaySequence(T start, T finish, float duration, Action onComplete = null)
		{
			return null;
		}

		protected virtual void OnAnimationCurveChanged(AnimationCurve value)
		{
		}

		protected virtual void OnTargetChanged(T newTarget)
		{
		}

		protected virtual void PreprocessTween()
		{
		}

		protected TweenableVariableBase()
		{
			((BindableVariable<T>)(object)this)._002Ector((T)default(T), checkEquality: false, (Func<T, T, bool>)null, startInitialized: false);
		}
	}
}
