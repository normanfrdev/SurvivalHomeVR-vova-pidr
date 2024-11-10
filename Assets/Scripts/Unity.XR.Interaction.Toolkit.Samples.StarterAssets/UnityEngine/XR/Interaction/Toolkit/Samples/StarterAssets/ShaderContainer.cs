using System;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	[Serializable]
	public class ShaderContainer
	{
		public Material material;

		public bool useSRPShaderName;

		public string scriptableRenderPipelineShaderName;

		public Shader scriptableRenderPipelineShader;

		public bool useBuiltinShaderName;

		public string builtInPipelineShaderName;

		public Shader builtInPipelineShader;
	}
}
