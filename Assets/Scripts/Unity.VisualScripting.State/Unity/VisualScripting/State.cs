using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public abstract class State : GraphElement<StateGraph>, IState, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable, IGraphElementWithData
	{
		public class Data : IGraphElementData
		{
			public bool isActive;

			public bool hasEntered;
		}

		public class DebugData : IStateDebugData, IGraphElementDebugData
		{
			public int lastEnterFrame
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

			public float lastExitTime
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
		}

		public const float DefaultWidth = 170f;

		[Serialize]
		public bool isStart
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

		[DoNotSerialize]
		public virtual bool canBeSource => false;

		[DoNotSerialize]
		public virtual bool canBeDestination => false;

		public IEnumerable<IStateTransition> outgoingTransitions => null;

		public IEnumerable<IStateTransition> incomingTransitions => null;

		protected List<IStateTransition> outgoingTransitionsNoAlloc => null;

		public IEnumerable<IStateTransition> transitions => null;

		[Serialize]
		public Vector2 position
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Serialize]
		public float width
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

		public IGraphElementData CreateData()
		{
			return null;
		}

		public IGraphElementDebugData CreateDebugData()
		{
			return null;
		}

		public override void BeforeRemove()
		{
		}

		public override void Instantiate(GraphReference instance)
		{
		}

		public override void Uninstantiate(GraphReference instance)
		{
		}

		protected void CopyFrom(State source)
		{
		}

		public void Disconnect()
		{
		}

		public virtual void OnEnter(Flow flow, StateEnterReason reason)
		{
		}

		public virtual void OnExit(Flow flow, StateExitReason reason)
		{
		}

		protected virtual void OnEnterImplementation(Flow flow)
		{
		}

		protected virtual void UpdateImplementation(Flow flow)
		{
		}

		protected virtual void FixedUpdateImplementation(Flow flow)
		{
		}

		protected virtual void LateUpdateImplementation(Flow flow)
		{
		}

		protected virtual void OnExitImplementation(Flow flow)
		{
		}

		public virtual void OnBranchTo(Flow flow, IState destination)
		{
		}

		public override AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}

		protected State()
		{
			((GraphElement<TGraph>)(object)this)._002Ector();
		}

		StateGraph IState.get_graph()
		{
			return null;
		}
	}
}
