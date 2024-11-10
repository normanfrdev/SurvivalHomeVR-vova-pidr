using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Graphs/Graph Nodes")]
	public abstract class SetGraph<TGraph, TMacro, TMachine> : Unit where TGraph : class, IGraph, new() where TMacro : Macro<TGraph> where TMachine : Machine<TGraph, TMacro>
	{
		[DoNotSerialize]
		[PortLabelHidden]
		public ControlInput enter
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

		[DoNotSerialize]
		[PortLabelHidden]
		[NullMeansSelf]
		public ValueInput target
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

		[DoNotSerialize]
		[PortLabel("Graph")]
		[PortLabelHidden]
		public ValueInput graphInput
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

		[DoNotSerialize]
		[PortLabel("Graph")]
		[PortLabelHidden]
		public ValueOutput graphOutput
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

		[DoNotSerialize]
		[PortLabelHidden]
		public ControlOutput exit
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

		protected abstract bool isGameObject { get; }

		private Type targetType => null;

		protected override void Definition()
		{
		}

		private ControlOutput SetMacro(Flow flow)
		{
			return null;
		}
	}
}
