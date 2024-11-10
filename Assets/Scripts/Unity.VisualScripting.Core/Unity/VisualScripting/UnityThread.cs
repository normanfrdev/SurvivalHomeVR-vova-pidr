using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace Unity.VisualScripting
{
	public static class UnityThread
	{
		public static Thread thread;

		public static Action<Action> editorAsync;

		public static ConcurrentQueue<Action> pendingQueue;

		public static bool allowsAPI => false;

		internal static void RuntimeInitialize()
		{
		}

		[Conditional("UNITY_EDITOR")]
		public static void EditorAsync(Action action)
		{
		}
	}
}
