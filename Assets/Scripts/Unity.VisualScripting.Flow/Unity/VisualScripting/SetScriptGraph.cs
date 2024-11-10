using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.VisualScripting
{
	[TypeIcon(typeof(FlowGraph))]
	public sealed class SetScriptGraph : SetGraph<FlowGraph, ScriptGraphAsset, ScriptMachine>
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

		public SetScriptGraph()
		{
			((SetGraph<, , >)(object)this)._002Ector();
		}
	}
}
