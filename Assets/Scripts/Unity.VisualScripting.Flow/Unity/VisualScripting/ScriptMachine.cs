using UnityEngine;

namespace Unity.VisualScripting
{
	[AddComponentMenu("Visual Scripting/Script Machine")]
	[RequireComponent(typeof(Variables))]
	[DisableAnnotation]
	[RenamedFrom("Bolt.FlowMachine")]
	[RenamedFrom("Unity.VisualScripting.FlowMachine")]
	public sealed class ScriptMachine : EventMachine<FlowGraph, ScriptGraphAsset>
	{
		public override FlowGraph DefaultGraph()
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnInstantiateWhileEnabled()
		{
		}

		protected override void OnUninstantiateWhileEnabled()
		{
		}

		protected override void OnDisable()
		{
		}

		[ContextMenu("Show Data...")]
		protected override void ShowData()
		{
		}

		public ScriptMachine()
		{
			((EventMachine<TGraph, TMacro>)(object)this)._002Ector();
		}
	}
}
