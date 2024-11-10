using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public abstract class NesterState<TGraph, TMacro> : State, INesterState, IState, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable, IGraphElementWithData, IGraphNesterElement, IGraphParentElement, IGraphParent, IGraphNester where TGraph : class, IGraph, new() where TMacro : Macro<TGraph>
	{
		[Serialize]
		public GraphNest<TGraph, TMacro> nest
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
		IGraphNest IGraphNester.nest => null;

		[DoNotSerialize]
		IGraph IGraphParent.childGraph => null;

		[DoNotSerialize]
		bool IGraphParent.isSerializationRoot => false;

		[DoNotSerialize]
		UnityEngine.Object IGraphParent.serializedObject => null;

		[DoNotSerialize]
		public override IEnumerable<ISerializationDependency> deserializationDependencies => null;

		protected NesterState()
		{
		}

		protected NesterState(TMacro macro)
		{
		}

		protected void CopyFrom(NesterState<TGraph, TMacro> source)
		{
		}

		public override IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}

		public abstract TGraph DefaultGraph();

		IGraph IGraphParent.DefaultGraph()
		{
			return null;
		}

		void IGraphNester.InstantiateNest()
		{
		}

		void IGraphNester.UninstantiateNest()
		{
		}

		StateGraph IState.get_graph()
		{
			return null;
		}
	}
}
