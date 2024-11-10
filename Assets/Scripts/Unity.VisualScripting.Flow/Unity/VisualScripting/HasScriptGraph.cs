using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.VisualScripting
{
	[TypeIcon(typeof(FlowGraph))]
	[UnitCategory("Graphs/Graph Nodes")]
	public sealed class HasScriptGraph : HasGraph<FlowGraph, ScriptGraphAsset, ScriptMachine>
	{
		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable]
		[UsedImplicitly]
		public ScriptGraphContainerType containerType
		{
			[CompilerGenerated]
			get
			{
				return default(ScriptGraphContainerType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override bool isGameObject => false;

		public HasScriptGraph()
		{
			((HasGraph<, , >)(object)this)._002Ector();
		}
	}
}
