using System.Threading;
using System.Threading.Tasks;

namespace Unity.XR.CoreUtils.Bindings.Variables
{
	internal struct BindableVariableTaskState<T>
	{
		private readonly TaskCompletionSource<T> m_Tcs;

		private readonly T m_AwaitState;

		private readonly IReadOnlyBindableVariable<T> m_BindableVariable;

		public Task<T> task => null;

		public BindableVariableTaskState(IReadOnlyBindableVariable<T> bindableVariable, T awaitState, CancellationToken cancellationToken = default(CancellationToken))
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
