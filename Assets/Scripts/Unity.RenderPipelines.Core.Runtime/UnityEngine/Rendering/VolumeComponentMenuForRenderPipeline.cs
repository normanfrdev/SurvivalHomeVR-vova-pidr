using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu
	{
		public Type[] pipelineTypes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public VolumeComponentMenuForRenderPipeline(string menu, params Type[] pipelineTypes)
			: base(null)
		{
		}
	}
}
