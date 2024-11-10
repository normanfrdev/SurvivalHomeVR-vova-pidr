using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public abstract class StateTransition : GraphElement<StateGraph>, IStateTransition, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable, IConnection<IState, IState>
	{
		public class DebugData : IStateTransitionDebugData, IGraphElementDebugData
		{
			public Exception runtimeException
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

			public int lastBranchFrame
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

			public float lastBranchTime
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}
		}

		public override int dependencyOrder => 0;

		[Serialize]
		public IState source
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

		[Serialize]
		public IState destination
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

		protected StateTransition()
		{
			((GraphElement<TGraph>)(object)this)._002Ector();
		}

		protected StateTransition(IState source, IState destination)
		{
			((GraphElement<TGraph>)(object)this)._002Ector();
		}

		public IGraphElementDebugData CreateDebugData()
		{
			return null;
		}

		public override void Instantiate(GraphReference instance)
		{
		}

		public override void Uninstantiate(GraphReference instance)
		{
		}

		public void Branch(Flow flow)
		{
		}

		public abstract void OnEnter(Flow flow);

		public abstract void OnExit(Flow flow);

		public override AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}
	}
}
