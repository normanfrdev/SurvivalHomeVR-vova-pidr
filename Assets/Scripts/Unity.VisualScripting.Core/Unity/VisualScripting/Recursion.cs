using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public class Recursion<T> : IPoolable, IDisposable
	{
		private readonly Stack<T> traversedOrder;

		private readonly Dictionary<T, int> traversedCount;

		private bool disposed;

		protected int maxDepth;

		protected Recursion()
		{
		}

		public void Enter(T o)
		{
		}

		public bool TryEnter(T o)
		{
			return false;
		}

		public void Exit(T o)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Free()
		{
		}

		void IPoolable.New()
		{
		}

		void IPoolable.Free()
		{
		}

		public static Recursion<T> New()
		{
			return null;
		}

		public static Recursion<T> New(int maxDepth)
		{
			return null;
		}
	}
	public sealed class Recursion : Recursion<object>
	{
		public static int defaultMaxDepth
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool safeMode
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

		private Recursion()
		{
			((Recursion<>)(object)this)._002Ector();
		}

		internal static void OnRuntimeMethodLoad()
		{
		}

		protected override void Free()
		{
		}

		public new static Recursion New()
		{
			return null;
		}

		public new static Recursion New(int maxDepth)
		{
			return null;
		}
	}
}
