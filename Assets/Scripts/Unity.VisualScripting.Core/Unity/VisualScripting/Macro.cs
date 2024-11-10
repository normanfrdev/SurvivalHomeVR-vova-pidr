using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[DisableAnnotation]
	public abstract class Macro<TGraph> : MacroScriptableObject, IMacro, IGraphRoot, IGraphParent, ISerializationDependency, ISerializationCallbackReceiver, IAotStubbable where TGraph : class, IGraph, new()
	{
		[SerializeAs("graph")]
		private TGraph _graph;

		[DoNotSerialize]
		private GraphReference _reference;

		[DoNotSerialize]
		public TGraph graph
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
		IGraph IMacro.graph
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
		IGraph IGraphParent.childGraph => null;

		[DoNotSerialize]
		bool IGraphParent.isSerializationRoot => false;

		[DoNotSerialize]
		Object IGraphParent.serializedObject => null;

		[DoNotSerialize]
		protected GraphReference reference => null;

		public bool isDescriptionValid
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		bool ISerializationDependency.IsDeserialized
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

		public IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}

		protected override void OnBeforeDeserialize()
		{
		}

		protected override void OnAfterDeserialize()
		{
		}

		public abstract TGraph DefaultGraph();

		IGraph IGraphParent.DefaultGraph()
		{
			return null;
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public GraphPointer GetReference()
		{
			return null;
		}
	}
}
