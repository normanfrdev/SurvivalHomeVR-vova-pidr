using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public sealed class Flow : IPoolable, IDisposable
	{
		private struct RecursionNode : IEquatable<RecursionNode>
		{
			public readonly IUnitPort port
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public readonly IGraphParent context
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public RecursionNode(IUnitPort port, GraphPointer pointer)
			{
			}

			public bool Equals(RecursionNode other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		[CompilerGenerated]
		private sealed class _003CCoroutine_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Flow _003C_003E4__this;

			public ControlOutput startPort;

			private IEnumerator _003C_003E7__wrap1;

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
			public _003CCoroutine_003Ed__53(int _003C_003E1__state)
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
		}

		[CompilerGenerated]
		private sealed class _003CInvokeCoroutine_003Ed__55 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private ControlOutput output;

			public ControlOutput _003C_003E3__output;

			public Flow _003C_003E4__this;

			private RecursionNode _003CrecursionNode_003E5__2;

			private IEnumerator _003C_003E7__wrap2;

			private IEnumerator _003C_003E7__wrap3;

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
			public _003CInvokeCoroutine_003Ed__55(int _003C_003E1__state)
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

			private void _003C_003Em__Finally3()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
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
		private sealed class _003CInvokeCoroutineDelegate_003Ed__59 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private ControlInput input;

			public ControlInput _003C_003E3__input;

			public Flow _003C_003E4__this;

			private IEnumerator _003Cinstructions_003E5__2;

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
			public _003CInvokeCoroutineDelegate_003Ed__59(int _003C_003E1__state)
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
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private Recursion<RecursionNode> recursion;

		private readonly Dictionary<IUnitValuePort, object> locals;

		public readonly VariableDeclarations variables;

		private readonly Stack<int> loops;

		private readonly HashSet<GraphStack> preservedStacks;

		private ICollection<Flow> activeCoroutinesRegistry;

		private bool coroutineStopRequested;

		private IEnumerator coroutineEnumerator;

		private bool disposed;

		public int loopIdentifier;

		public GraphStack stack
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MonoBehaviour coroutineRunner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isCoroutine
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool isPrediction
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool enableDebug => false;

		public static Func<GraphPointer, bool> isInspectedBinding
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isInspected => false;

		public int currentLoop => 0;

		private Flow()
		{
		}

		public static Flow New(GraphReference reference)
		{
			return null;
		}

		void IPoolable.New()
		{
		}

		public void Dispose()
		{
		}

		void IPoolable.Free()
		{
		}

		public GraphStack PreserveStack()
		{
			return null;
		}

		public void RestoreStack(GraphStack stack)
		{
		}

		public void DisposePreservedStack(GraphStack stack)
		{
		}

		public bool LoopIsNotBroken(int loop)
		{
			return false;
		}

		public int EnterLoop()
		{
			return 0;
		}

		public void BreakLoop()
		{
		}

		public void ExitLoop(int loop)
		{
		}

		public void Run(ControlOutput port)
		{
		}

		public void StartCoroutine(ControlOutput port, ICollection<Flow> registry = null)
		{
		}

		public void StopCoroutine(bool disposeInstantly)
		{
		}

		internal void StopCoroutineImmediate()
		{
		}

		[IteratorStateMachine(typeof(_003CCoroutine_003Ed__53))]
		private IEnumerator Coroutine(ControlOutput startPort)
		{
			return null;
		}

		public void Invoke(ControlOutput output)
		{
		}

		[IteratorStateMachine(typeof(_003CInvokeCoroutine_003Ed__55))]
		private IEnumerable InvokeCoroutine(ControlOutput output)
		{
			return null;
		}

		private RecursionNode BeforeInvoke(ControlOutput output, RecursionNode recursionNode)
		{
			return default(RecursionNode);
		}

		private void AfterInvoke(ControlOutput output, RecursionNode recursionNode)
		{
		}

		private ControlOutput InvokeDelegate(ControlInput input)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CInvokeCoroutineDelegate_003Ed__59))]
		private IEnumerable InvokeCoroutineDelegate(ControlInput input)
		{
			return null;
		}

		public bool IsLocal(IUnitValuePort port)
		{
			return false;
		}

		public void SetValue(IUnitValuePort port, object value)
		{
		}

		public object GetValue(ValueInput input)
		{
			return null;
		}

		private object GetValue(ValueOutput output)
		{
			return null;
		}

		public object GetValue(ValueInput input, Type type)
		{
			return null;
		}

		public T GetValue<T>(ValueInput input)
		{
			return default(T);
		}

		public object GetConvertedValue(ValueInput input)
		{
			return null;
		}

		private object GetDefaultValue(ValueInput input)
		{
			return null;
		}

		public bool TryGetDefaultValue(ValueInput input, out object defaultValue)
		{
			defaultValue = null;
			return false;
		}

		private object GetValueDelegate(ValueOutput output)
		{
			return null;
		}

		public static object FetchValue(ValueInput input, GraphReference reference)
		{
			return null;
		}

		public static object FetchValue(ValueInput input, Type type, GraphReference reference)
		{
			return null;
		}

		public static T FetchValue<T>(ValueInput input, GraphReference reference)
		{
			return default(T);
		}

		public static bool CanPredict(IUnitValuePort port, GraphReference reference)
		{
			return false;
		}

		private bool CanPredict(ValueInput input)
		{
			return false;
		}

		private bool CanPredict(ValueOutput output)
		{
			return false;
		}

		private bool CanPredictDelegate(ValueOutput output)
		{
			return false;
		}

		public static object Predict(IUnitValuePort port, GraphReference reference)
		{
			return null;
		}

		public static object Predict(IUnitValuePort port, GraphReference reference, Type type)
		{
			return null;
		}

		public static T Predict<T>(IUnitValuePort port, GraphReference pointer)
		{
			return default(T);
		}
	}
}
