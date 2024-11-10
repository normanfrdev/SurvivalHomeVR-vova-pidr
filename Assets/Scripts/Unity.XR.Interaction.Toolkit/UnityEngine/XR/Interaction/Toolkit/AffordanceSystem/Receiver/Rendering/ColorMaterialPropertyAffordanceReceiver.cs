using System;
using System.Runtime.InteropServices;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering
{
	[AddComponentMenu("Affordance System/Receiver/Rendering/Color Material Property Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.ColorMaterialPropertyAffordanceReceiver.html")]
	[RequireComponent(typeof(MaterialPropertyBlockHelper))]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class ColorMaterialPropertyAffordanceReceiver : ColorAffordanceReceiver
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		private readonly struct ShaderPropertyLookup
		{
			public static readonly int baseColor;

			public static readonly int color;
		}

		[SerializeField]
		[Tooltip("Material Property Block Helper component reference used to set material properties.")]
		private MaterialPropertyBlockHelper m_MaterialPropertyBlockHelper;

		[SerializeField]
		[Tooltip("Shader property name to set the color of. When empty, the component will attempt to use the default for the current render pipeline.")]
		private string m_ColorPropertyName;

		private int m_ColorProperty;

		public MaterialPropertyBlockHelper materialPropertyBlockHelper
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string colorPropertyName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void OnValidate()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnAffordanceValueUpdated(Color newValue)
		{
		}

		protected override Color GetCurrentValueForCapture()
		{
			return default(Color);
		}

		private void UpdateColorPropertyID()
		{
		}
	}
}
