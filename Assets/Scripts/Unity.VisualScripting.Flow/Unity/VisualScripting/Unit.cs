using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	public abstract class Unit : GraphElement<FlowGraph>, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		public class DebugData : IUnitDebugData, IGraphElementDebugData
		{
			public int lastInvokeFrame
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

			public float lastInvokeTime
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

		[DoNotSerialize]
		public virtual bool canDefine => false;

		[DoNotSerialize]
		public bool failedToDefine => false;

		[DoNotSerialize]
		public bool isDefined
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

		[DoNotSerialize]
		public IUnitPortCollection<ControlInput> controlInputs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[DoNotSerialize]
		public IUnitPortCollection<ControlOutput> controlOutputs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[DoNotSerialize]
		public IUnitPortCollection<ValueInput> valueInputs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[DoNotSerialize]
		public IUnitPortCollection<ValueOutput> valueOutputs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[DoNotSerialize]
		public IUnitPortCollection<InvalidInput> invalidInputs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[DoNotSerialize]
		public IUnitPortCollection<InvalidOutput> invalidOutputs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[DoNotSerialize]
		public IEnumerable<IUnitInputPort> inputs => null;

		[DoNotSerialize]
		public IEnumerable<IUnitOutputPort> outputs => null;

		[DoNotSerialize]
		public IEnumerable<IUnitInputPort> validInputs => null;

		[DoNotSerialize]
		public IEnumerable<IUnitOutputPort> validOutputs => null;

		[DoNotSerialize]
		public IEnumerable<IUnitPort> ports => null;

		[DoNotSerialize]
		public IEnumerable<IUnitPort> invalidPorts => null;

		[DoNotSerialize]
		public IEnumerable<IUnitPort> validPorts => null;

		[Serialize]
		public Dictionary<string, object> defaultValues
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

		[DoNotSerialize]
		public IConnectionCollection<IUnitRelation, IUnitPort, IUnitPort> relations
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

		[DoNotSerialize]
		public IEnumerable<IUnitConnection> connections => null;

		[DoNotSerialize]
		public virtual bool isControlRoot
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

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

		[DoNotSerialize]
		public Exception definitionException
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public event Action onPortsChanged
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

		protected Unit()
		{
			((GraphElement<TGraph>)(object)this)._002Ector();
		}

		public virtual IGraphElementDebugData CreateDebugData()
		{
			return null;
		}

		public override void AfterAdd()
		{
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

		protected void CopyFrom(Unit source)
		{
		}

		protected abstract void Definition();

		protected virtual void AfterDefine()
		{
		}

		protected virtual void BeforeUndefine()
		{
		}

		private void Undefine()
		{
		}

		public void EnsureDefined()
		{
		}

		public void Define()
		{
		}

		public void RemoveUnconnectedInvalidPorts()
		{
		}

		public void PortsChanged()
		{
		}

		public void Disconnect()
		{
		}

		protected void EnsureUniqueInput(string key)
		{
		}

		protected void EnsureUniqueOutput(string key)
		{
		}

		protected ControlInput ControlInput(string key, Func<Flow, ControlOutput> action)
		{
			return null;
		}

		protected ControlInput ControlInputCoroutine(string key, Func<Flow, IEnumerator> coroutineAction)
		{
			return null;
		}

		protected ControlInput ControlInputCoroutine(string key, Func<Flow, ControlOutput> action, Func<Flow, IEnumerator> coroutineAction)
		{
			return null;
		}

		protected ControlOutput ControlOutput(string key)
		{
			return null;
		}

		protected ValueInput ValueInput(Type type, string key)
		{
			return null;
		}

		protected ValueInput ValueInput<T>(string key)
		{
			return null;
		}

		protected ValueInput ValueInput<T>(string key, T @default)
		{
			return null;
		}

		protected ValueOutput ValueOutput(Type type, string key)
		{
			return null;
		}

		protected ValueOutput ValueOutput(Type type, string key, Func<Flow, object> getValue)
		{
			return null;
		}

		protected ValueOutput ValueOutput<T>(string key)
		{
			return null;
		}

		protected ValueOutput ValueOutput<T>(string key, Func<Flow, T> getValue)
		{
			return null;
		}

		private void Relation(IUnitPort source, IUnitPort destination)
		{
		}

		protected void Requirement(ValueInput source, ControlInput destination)
		{
		}

		protected void Requirement(ValueInput source, ValueOutput destination)
		{
		}

		protected void Assignment(ControlInput source, ValueOutput destination)
		{
		}

		protected void Succession(ControlInput source, ControlOutput destination)
		{
		}

		public override AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
