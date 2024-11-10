using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class GraphNest<TGraph, TMacro> : IGraphNest, IAotStubbable where TGraph : class, IGraph, new() where TMacro : Macro<TGraph>
	{
		[CompilerGenerated]
		private sealed class _003Cget_deserializationDependencies_003Ed__41 : IEnumerable<ISerializationDependency>, IEnumerable, IEnumerator<ISerializationDependency>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private ISerializationDependency _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public GraphNest<TGraph, TMacro> _003C_003E4__this;

			ISerializationDependency IEnumerator<ISerializationDependency>.Current
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
			public _003Cget_deserializationDependencies_003Ed__41(int _003C_003E1__state)
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
			IEnumerator<ISerializationDependency> IEnumerable<ISerializationDependency>.GetEnumerator()
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
		private GraphSource _source;

		[DoNotSerialize]
		private TMacro _macro;

		[DoNotSerialize]
		private TGraph _embed;

		[DoNotSerialize]
		public IGraphNester nester
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

		[Serialize]
		public GraphSource source
		{
			get
			{
				return default(GraphSource);
			}
			set
			{
			}
		}

		[Serialize]
		public TMacro macro
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Serialize]
		public TGraph embed
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DoNotSerialize]
		public TGraph graph => null;

		IMacro IGraphNest.macro
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		IGraph IGraphNest.embed
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		IGraph IGraphNest.graph => null;

		Type IGraphNest.graphType => null;

		Type IGraphNest.macroType => null;

		public IEnumerable<ISerializationDependency> deserializationDependencies
		{
			[IteratorStateMachine(typeof(GraphNest<, >._003Cget_deserializationDependencies_003Ed__41))]
			get
			{
				return null;
			}
		}

		[DoNotSerialize]
		public bool hasBackgroundEmbed => false;

		public event Action beforeGraphChange
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

		public event Action afterGraphChange
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

		public void SwitchToEmbed(TGraph embed)
		{
		}

		public void SwitchToMacro(TMacro macro)
		{
		}

		private void BeforeGraphChange()
		{
		}

		private void AfterGraphChange()
		{
		}

		public IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}
	}
}
