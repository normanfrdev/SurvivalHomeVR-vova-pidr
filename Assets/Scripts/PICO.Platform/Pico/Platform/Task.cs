using System.Threading.Tasks;

namespace Pico.Platform
{
	public class Task
	{
		public readonly ulong TaskId;

		public bool HasSetCallback;

		public Task(ulong taskId)
		{
		}

		public Task OnComplete(Message.Handler handler)
		{
			return null;
		}

		public System.Threading.Tasks.Task<Message> Async()
		{
			return null;
		}
	}
	public class Task<T> : Task
	{
		public Task(ulong taskId)
			: base(0uL)
		{
		}

		public Task<T> OnComplete(Message<T>.Handler handler)
		{
			return null;
		}

		public new System.Threading.Tasks.Task<Message<T>> Async()
		{
			return null;
		}
	}
}
