using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.VisualScripting
{
	[TypeIcon(typeof(StateGraph))]
	[UnitCategory("Graphs/Graph Nodes")]
	public sealed class HasStateGraph : HasGraph<StateGraph, StateGraphAsset, StateMachine>
	{
		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable]
		[UsedImplicitly]
		public StateGraphContainerType containerType
		{
			[CompilerGenerated]
			get
			{
				return default(StateGraphContainerType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override bool isGameObject => false;

		public HasStateGraph()
		{
			((HasGraph<TGraph, TMacro, TMachine>)(object)this)._002Ector();
		}
	}
}
