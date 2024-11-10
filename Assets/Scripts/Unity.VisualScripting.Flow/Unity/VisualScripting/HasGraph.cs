using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[UnitCategory("Graphs/Graph Nodes")]
	public abstract class HasGraph<TGraph, TMacro, TMachine> : Unit where TGraph : class, IGraph, new() where TMacro : Macro<TGraph> where TMachine : Machine<TGraph, TMacro>
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
			private set
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
			private set
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
			private set
			{
			}
		}

		[DoNotSerialize]
		[PortLabel("Has Graph")]
		[PortLabelHidden]
		public ValueOutput hasGraphOutput
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
		[PortLabelHidden]
		public ControlOutput exit
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

		protected abstract bool isGameObject { get; }

		private Type targetType => null;

		protected override void Definition()
		{
		}

		private ControlOutput TriggerHasGraph(Flow flow)
		{
			return null;
		}

		private bool OutputHasGraph(Flow flow)
		{
			return false;
		}
	}
}
