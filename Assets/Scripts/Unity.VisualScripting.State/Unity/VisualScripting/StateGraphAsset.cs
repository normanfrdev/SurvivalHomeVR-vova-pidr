using UnityEngine;

namespace Unity.VisualScripting
{
	[TypeIcon(typeof(StateGraph))]
	[CreateAssetMenu(menuName = "Visual Scripting/State Graph", fileName = "New State Graph", order = 81)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.visualscripting@latest/index.html?subfolder=/manual/vs-state-graphs-intro.html")]
	public sealed class StateGraphAsset : Macro<StateGraph>
	{
		[ContextMenu("Show Data...")]
		protected override void ShowData()
		{
		}

		public override StateGraph DefaultGraph()
		{
			return null;
		}

		public StateGraphAsset()
		{
			((Macro<TGraph>)(object)this)._002Ector();
		}
	}
}
