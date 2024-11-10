using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public sealed class GraphReference : GraphPointer
	{
		[CompilerGenerated]
		private sealed class _003CGetBreadcrumbs_003Ed__22 : IEnumerable<GraphReference>, IEnumerable, IEnumerator<GraphReference>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private GraphReference _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public GraphReference _003C_003E4__this;

			private int _003Cdepth_003E5__2;

			GraphReference IEnumerator<GraphReference>.Current
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
			public _003CGetBreadcrumbs_003Ed__22(int _003C_003E1__state)
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
			IEnumerator<GraphReference> IEnumerable<GraphReference>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[DoNotSerialize]
		private int hashCode;

		private static readonly Dictionary<int, List<GraphReference>> internPool;

		static GraphReference()
		{
		}

		private GraphReference()
		{
		}

		public static GraphReference New(IGraphRoot root, bool ensureValid)
		{
			return null;
		}

		public static GraphReference New(IGraphRoot root, IEnumerable<IGraphParentElement> parentElements, bool ensureValid)
		{
			return null;
		}

		public static GraphReference New(UnityEngine.Object rootObject, IEnumerable<Guid> parentElementGuids, bool ensureValid)
		{
			return null;
		}

		private static GraphReference New(GraphPointer model)
		{
			return null;
		}

		public override void CopyFrom(GraphPointer other)
		{
		}

		public GraphReference Clone()
		{
			return null;
		}

		public override GraphReference AsReference()
		{
			return null;
		}

		public GraphStack ToStackPooled()
		{
			return null;
		}

		internal void Release()
		{
		}

		public void CreateGraphData()
		{
		}

		public void FreeGraphData()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private void Hash()
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(GraphReference x, GraphReference y)
		{
			return false;
		}

		public static bool operator !=(GraphReference x, GraphReference y)
		{
			return false;
		}

		public GraphReference ParentReference(bool ensureValid)
		{
			return null;
		}

		public GraphReference ChildReference(IGraphParentElement parentElement, bool ensureValid, int? maxRecursionDepth = null)
		{
			return null;
		}

		public GraphReference Revalidate(bool ensureValid)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetBreadcrumbs_003Ed__22))]
		public IEnumerable<GraphReference> GetBreadcrumbs()
		{
			return null;
		}

		public static GraphReference Intern(GraphPointer pointer)
		{
			return null;
		}

		internal static void ClearIntern(GraphPointer pointer)
		{
		}

		public static void FreeInvalidInterns()
		{
		}
	}
}
