using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public static class LinqUtility
	{
		[CompilerGenerated]
		private sealed class _003CCatch_003Ed__14<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<T> source;

			public IEnumerable<T> _003C_003E3__source;

			private Action<Exception> @catch;

			public Action<Exception> _003C_003E3__catch;

			private IEnumerator<T> _003Cenumerator_003E5__2;

			private bool _003Csuccess_003E5__3;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CCatch_003Ed__14(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CConcat_003Ed__0<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable[] enumerables;

			public IEnumerable[] _003C_003E3__enumerables;

			private IEnumerator<IEnumerable> _003C_003E7__wrap1;

			private IEnumerator<T> _003C_003E7__wrap2;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CConcat_003Ed__0(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CYield_003Ed__3<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private T t;

			public T _003C_003E3__t;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
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
			public _003CYield_003Ed__3(int _003C_003E1__state)
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

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[IteratorStateMachine(typeof(_003CConcat_003Ed__0<>))]
		public static IEnumerable<T> Concat<T>(params IEnumerable[] enumerables)
		{
			return null;
		}

		public static IEnumerable<T> DistinctBy<T, TKey>(this IEnumerable<T> items, Func<T, TKey> property)
		{
			return null;
		}

		public static IEnumerable<T> NotNull<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CYield_003Ed__3<>))]
		public static IEnumerable<T> Yield<T>(this T t)
		{
			return null;
		}

		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}

		public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> items)
		{
		}

		public static void AddRange(this IList list, IEnumerable items)
		{
		}

		public static ICollection<T> AsReadOnlyCollection<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}

		public static IList<T> AsReadOnlyList<T>(this IEnumerable<T> enumerable)
		{
			return null;
		}

		public static IEnumerable<T> Flatten<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>> childrenSelector)
		{
			return null;
		}

		public static IEnumerable<T> IntersectAll<T>(this IEnumerable<IEnumerable<T>> groups)
		{
			return null;
		}

		public static IEnumerable<T> OrderByDependencies<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>> getDependencies, bool throwOnCycle = true)
		{
			return null;
		}

		private static void OrderByDependenciesVisit<T>(T item, HashSet<T> visited, List<T> sorted, Func<T, IEnumerable<T>> getDependencies, bool throwOnCycle)
		{
		}

		public static IEnumerable<T> OrderByDependers<T>(this IEnumerable<T> source, Func<T, IEnumerable<T>> getDependers, bool throwOnCycle = true)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCatch_003Ed__14<>))]
		public static IEnumerable<T> Catch<T>(this IEnumerable<T> source, Action<Exception> @catch)
		{
			return null;
		}

		public static IEnumerable<T> Catch<T>(this IEnumerable<T> source, ICollection<Exception> exceptions)
		{
			return null;
		}

		public static IEnumerable<T> CatchAsLogError<T>(this IEnumerable<T> source, string message)
		{
			return null;
		}

		public static IEnumerable<T> CatchAsLogWarning<T>(this IEnumerable<T> source, string message)
		{
			return null;
		}
	}
}
