using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort
{
	[AddComponentMenu("XR/Locomotion/Tunneling Vignette Controller", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort.TunnelingVignetteController.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class TunnelingVignetteController : MonoBehaviour
	{
		private static class ShaderPropertyLookup
		{
			public static readonly int apertureSize;

			public static readonly int featheringEffect;

			public static readonly int vignetteColor;

			public static readonly int vignetteColorBlend;
		}

		private class ProviderRecord
		{
			public ITunnelingVignetteProvider provider
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public EaseState easeState
			{
				[CompilerGenerated]
				get
				{
					return default(EaseState);
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public float dynamicApertureSize
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public bool easeInLockEnded
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

			public float dynamicEaseOutDelayTime
			{
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public ProviderRecord(ITunnelingVignetteProvider provider)
			{
			}
		}

		private const string k_DefaultShader = "VR/TunnelingVignette";

		[SerializeField]
		private VignetteParameters m_DefaultParameters;

		[SerializeField]
		private VignetteParameters m_CurrentParameters;

		[SerializeField]
		private List<LocomotionVignetteProvider> m_LocomotionVignetteProviders;

		private readonly List<ProviderRecord> m_ProviderRecords;

		private MeshRenderer m_MeshRender;

		private MeshFilter m_MeshFilter;

		private Material m_SharedMaterial;

		private MaterialPropertyBlock m_VignettePropertyBlock;

		public VignetteParameters defaultParameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VignetteParameters currentParameters => null;

		public List<LocomotionVignetteProvider> locomotionVignetteProviders
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void BeginTunnelingVignette(ITunnelingVignetteProvider provider)
		{
		}

		public void EndTunnelingVignette(ITunnelingVignetteProvider provider)
		{
		}

		[Conditional("UNITY_EDITOR")]
		internal void PreviewInEditor(VignetteParameters previewParameters)
		{
		}

		protected virtual void Awake()
		{
		}

		[Conditional("UNITY_EDITOR")]
		protected virtual void Reset()
		{
		}

		protected virtual void Update()
		{
		}

		private void UpdateTunnelingVignette(VignetteParameters parameters)
		{
		}

		private bool TrySetUpMaterial()
		{
			return false;
		}
	}
}
