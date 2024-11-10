using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	public abstract class NesterUnit<TGraph, TMacro> : Unit, INesterUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable, IGraphNesterElement, IGraphParentElement, IGraphParent, IGraphNester where TGraph : class, IGraph, new() where TMacro : Macro<TGraph>
	{
		public override bool canDefine => false;

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

		protected NesterUnit()
		{
		}

		protected NesterUnit(TMacro macro)
		{
		}

		public override IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}

		protected void CopyFrom(NesterUnit<TGraph, TMacro> source)
		{
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

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
