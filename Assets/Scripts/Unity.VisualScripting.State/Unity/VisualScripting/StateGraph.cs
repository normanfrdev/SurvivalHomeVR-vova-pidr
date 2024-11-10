using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	public sealed class StateGraph : Graph, IGraphEventListener
	{
		[DoNotSerialize]
		public GraphElementCollection<IState> states
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		[DoNotSerialize]
		public GraphConnectionCollection<IStateTransition, IState, IState> transitions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		[DoNotSerialize]
		public GraphElementCollection<GraphGroup> groups
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		[DoNotSerialize]
		public GraphElementCollection<StickyNote> sticky
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

		public override IGraphData CreateData()
		{
			return null;
		}

		public void StartListening(GraphStack stack)
		{
		}

		public void StopListening(GraphStack stack)
		{
		}

		public bool IsListening(GraphPointer pointer)
		{
			return false;
		}

		private HashSet<IState> GetActiveStatesNoAlloc(GraphPointer pointer)
		{
			return null;
		}

		public void Start(Flow flow)
		{
		}

		public void Stop(Flow flow)
		{
		}

		public static StateGraph WithStart()
		{
			return null;
		}
	}
}
