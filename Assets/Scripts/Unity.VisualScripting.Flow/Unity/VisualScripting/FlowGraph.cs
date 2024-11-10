using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	[DisplayName("Script Graph")]
	public sealed class FlowGraph : Graph, IGraphWithVariables, IGraph, IDisposable, IPrewarmable, IAotStubbable, ISerializationDepender, ISerializationCallbackReceiver, IGraphEventListener
	{
		private const string DefinitionRemoveWarningTitle = "Remove Port Definition";

		private const string DefinitionRemoveWarningMessage = "Removing this definition will break any existing connection to this port. Are you sure you want to continue?";

		[Serialize]
		public VariableDeclarations variables
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
		public GraphElementCollection<IUnit> units
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
		public GraphConnectionCollection<ControlConnection, ControlOutput, ControlInput> controlConnections
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
		public GraphConnectionCollection<ValueConnection, ValueOutput, ValueInput> valueConnections
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
		public GraphConnectionCollection<InvalidConnection, IUnitOutputPort, IUnitInputPort> invalidConnections
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
		public GraphElementCollection<GraphGroup> groups
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

		[Serialize]
		[InspectorLabel("Trigger Inputs")]
		[InspectorWide(true)]
		[WarnBeforeRemoving("Remove Port Definition", "Removing this definition will break any existing connection to this port. Are you sure you want to continue?")]
		public UnitPortDefinitionCollection<ControlInputDefinition> controlInputDefinitions
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

		[Serialize]
		[InspectorLabel("Trigger Outputs")]
		[InspectorWide(true)]
		[WarnBeforeRemoving("Remove Port Definition", "Removing this definition will break any existing connection to this port. Are you sure you want to continue?")]
		public UnitPortDefinitionCollection<ControlOutputDefinition> controlOutputDefinitions
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

		[Serialize]
		[InspectorLabel("Data Inputs")]
		[InspectorWide(true)]
		[WarnBeforeRemoving("Remove Port Definition", "Removing this definition will break any existing connection to this port. Are you sure you want to continue?")]
		public UnitPortDefinitionCollection<ValueInputDefinition> valueInputDefinitions
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

		[Serialize]
		[InspectorLabel("Data Outputs")]
		[InspectorWide(true)]
		[WarnBeforeRemoving("Remove Port Definition", "Removing this definition will break any existing connection to this port. Are you sure you want to continue?")]
		public UnitPortDefinitionCollection<ValueOutputDefinition> valueOutputDefinitions
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

		public IEnumerable<IUnitPortDefinition> validPortDefinitions => null;

		public event Action onPortDefinitionsChanged
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

		public IEnumerable<string> GetDynamicVariableNames(VariableKind kind, GraphReference reference)
		{
			return null;
		}

		public void PortDefinitionsChanged()
		{
		}

		public static FlowGraph WithInputOutput()
		{
			return null;
		}

		public static FlowGraph WithStartUpdate()
		{
			return null;
		}
	}
}
