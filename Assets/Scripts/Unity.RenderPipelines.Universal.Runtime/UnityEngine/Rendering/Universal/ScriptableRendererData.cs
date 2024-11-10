using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.Universal
{
	public abstract class ScriptableRendererData : ScriptableObject
	{
		[Serializable]
		[ReloadGroup]
		public sealed class DebugShaderResources
		{
			[Reload("Shaders/Debug/DebugReplacement.shader", ReloadAttribute.Package.Root)]
			public Shader debugReplacementPS;

			[Reload("Shaders/Debug/HDRDebugView.shader", ReloadAttribute.Package.Root)]
			public Shader hdrDebugViewPS;
		}

		public DebugShaderResources debugShaders;

		[SerializeField]
		internal List<ScriptableRendererFeature> m_RendererFeatures;

		[SerializeField]
		internal List<long> m_RendererFeatureMap;

		[SerializeField]
		private bool m_UseNativeRenderPass;

		internal bool isInvalidated
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<ScriptableRendererFeature> rendererFeatures => null;

		public bool useNativeRenderPass
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected abstract ScriptableRenderer Create();

		public new void SetDirty()
		{
		}

		internal ScriptableRenderer InternalCreateRenderer()
		{
			return null;
		}

		protected virtual void OnValidate()
		{
		}

		protected virtual void OnEnable()
		{
		}

		internal bool TryGetRendererFeature<T>(out T rendererFeature) where T : ScriptableRendererFeature
		{
			rendererFeature = null;
			return false;
		}
	}
}
