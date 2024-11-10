using UnityEngine;

namespace Unity.VisualScripting
{
	[AddComponentMenu("Visual Scripting/State Machine")]
	[RequireComponent(typeof(Variables))]
	[DisableAnnotation]
	public sealed class StateMachine : EventMachine<StateGraph, StateGraphAsset>
	{
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

		public override StateGraph DefaultGraph()
		{
			return null;
		}

		public StateMachine()
		{
			((EventMachine<TGraph, TMacro>)(object)this)._002Ector();
		}
	}
}
