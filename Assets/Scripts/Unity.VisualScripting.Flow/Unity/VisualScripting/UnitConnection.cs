using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public abstract class UnitConnection<TSourcePort, TDestinationPort> : GraphElement<FlowGraph>, IConnection<TSourcePort, TDestinationPort> where TSourcePort : class, IUnitOutputPort where TDestinationPort : class, IUnitInputPort
	{
		[Serialize]
		protected IUnit sourceUnit
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
		protected string sourceKey
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
		protected IUnit destinationUnit
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
		protected string destinationKey
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
		public abstract TSourcePort source { get; }

		[DoNotSerialize]
		public abstract TDestinationPort destination { get; }

		public override int dependencyOrder => 0;

		public abstract bool sourceExists { get; }

		public abstract bool destinationExists { get; }

		[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
		protected UnitConnection()
		{
			((GraphElement<TGraph>)(object)this)._002Ector();
		}

		protected UnitConnection(TSourcePort source, TDestinationPort destination)
		{
			((GraphElement<TGraph>)(object)this)._002Ector();
		}

		public virtual IGraphElementDebugData CreateDebugData()
		{
			return null;
		}

		protected void CopyFrom(UnitConnection<TSourcePort, TDestinationPort> source)
		{
		}

		public override bool HandleDependencies()
		{
			return false;
		}

		public override AnalyticsIdentifier GetAnalyticsIdentifier()
		{
			return null;
		}
	}
}
