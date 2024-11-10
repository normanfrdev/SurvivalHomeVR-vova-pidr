using UnityEngine;

namespace Unity.VisualScripting
{
	[TypeIcon(typeof(FlowGraph))]
	[CreateAssetMenu(menuName = "Visual Scripting/Script Graph", fileName = "New Script Graph", order = 81)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.visualscripting@latest/index.html?subfolder=/manual/vs-script-graphs-intro.html")]
	public sealed class ScriptGraphAsset : Macro<FlowGraph>
	{
		[ContextMenu("Show Data...")]
		protected override void ShowData()
		{
		}

		public override FlowGraph DefaultGraph()
		{
			return null;
		}

		public ScriptGraphAsset()
		{
			((Macro<TGraph>)(object)this)._002Ector();
		}
	}
}
