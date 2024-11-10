using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	[CreateAssetMenu(fileName = "MaterialPipelineHandler", menuName = "XR/MaterialPipelineHandler", order = 0)]
	public class MaterialPipelineHandler : ScriptableObject
	{
		[SerializeField]
		[Tooltip("List of materials and their associated shaders.")]
		private List<ShaderContainer> m_ShaderContainers;

		[SerializeField]
		[Tooltip("If true, the shaders will be refreshed automatically when the editor opens and when this scriptable object instance is enabled.")]
		private bool m_AutoRefreshShaders;

		public void AutoRefreshPipelineShaders()
		{
		}

		public void SetPipelineShaders()
		{
		}

		private static void MarkMaterialModified(Material material)
		{
		}
	}
}
