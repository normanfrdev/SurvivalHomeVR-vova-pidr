using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public abstract class GraphElement<TGraph> : IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable where TGraph : class, IGraph
	{
		[Serialize]
		public Guid guid
		{
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[DoNotSerialize]
		public virtual int dependencyOrder => 0;

		[DoNotSerialize]
		public TGraph graph
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

		[DoNotSerialize]
		IGraph IGraphElement.graph
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
		IGraph IGraphItem.graph => null;

		public virtual IEnumerable<ISerializationDependency> deserializationDependencies => null;

		public virtual void Instantiate(GraphReference instance)
		{
		}

		public virtual void Uninstantiate(GraphReference instance)
		{
		}

		public virtual void BeforeAdd()
		{
		}

		public virtual void AfterAdd()
		{
		}

		public virtual void BeforeRemove()
		{
		}

		public virtual void AfterRemove()
		{
		}

		public virtual void Dispose()
		{
		}

		protected void InstantiateNest()
		{
		}

		protected void UninstantiateNest()
		{
		}

		public virtual bool HandleDependencies()
		{
			return false;
		}

		public virtual IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}

		public virtual void Prewarm()
		{
		}

		protected void CopyFrom(GraphElement<TGraph> source)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public virtual AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}
	}
}
