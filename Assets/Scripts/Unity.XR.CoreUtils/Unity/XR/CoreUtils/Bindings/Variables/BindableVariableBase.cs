using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.XR.CoreUtils.Bindings.Variables
{
	[Serializable]
	public abstract class BindableVariableBase<T> : IReadOnlyBindableVariable<T>
	{
		private T m_InternalValue;

		private readonly bool m_CheckEquality;

		private bool m_IsInitialized;

		private readonly Func<T, T, bool> m_EqualityMethod;

		private int m_BindingCount;

		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public int BindingCount => 0;

		private event Action<T> valueUpdated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool SetValueWithoutNotify(T value)
		{
			return false;
		}

		public IEventBinding Subscribe(Action<T> callback)
		{
			return null;
		}

		public IEventBinding SubscribeAndUpdate(Action<T> callback)
		{
			return null;
		}

		public void Unsubscribe(Action<T> callback)
		{
		}

		private void IncrementReferenceCount()
		{
		}

		private void DecrementReferenceCount()
		{
		}

		protected BindableVariableBase(T initialValue = default(T), bool checkEquality = true, Func<T, T, bool> equalityMethod = null, bool startInitialized = false)
		{
		}

		public void BroadcastValue()
		{
		}

		public Task<T> Task(Func<T, bool> awaitPredicate, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		public Task<T> Task(T awaitState, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		public virtual bool ValueEquals(T other)
		{
			return false;
		}
	}
}
