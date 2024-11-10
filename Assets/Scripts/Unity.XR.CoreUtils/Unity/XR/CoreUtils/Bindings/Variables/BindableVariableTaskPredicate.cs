using System;
using System.Threading;
using System.Threading.Tasks;

namespace Unity.XR.CoreUtils.Bindings.Variables
{
	internal struct BindableVariableTaskPredicate<T>
	{
		private readonly TaskCompletionSource<T> m_Tcs;

		private readonly Func<T, bool> m_AwaitPredicate;

		private readonly IReadOnlyBindableVariable<T> m_BindableVariable;

		public Task<T> Task => null;

		public BindableVariableTaskPredicate(IReadOnlyBindableVariable<T> bindableVariable, Func<T, bool> awaitPredicate, CancellationToken cancellationToken = default(CancellationToken))
		{
		}

		private void Cancelled()
		{
		}

		private void Await(T state)
		{
		}
	}
}
