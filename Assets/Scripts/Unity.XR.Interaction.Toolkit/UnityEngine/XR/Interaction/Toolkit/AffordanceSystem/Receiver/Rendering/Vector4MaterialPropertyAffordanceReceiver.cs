using System;
using Unity.Mathematics;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering
{
	[AddComponentMenu("Affordance System/Receiver/Rendering/Vector4 Material Property Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.Vector4MaterialPropertyAffordanceReceiver.html")]
	[RequireComponent(typeof(MaterialPropertyBlockHelper))]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class Vector4MaterialPropertyAffordanceReceiver : Vector4AffordanceReceiver
	{
		[SerializeField]
		[Tooltip("Material Property Block Helper component reference used to set material properties.")]
		private MaterialPropertyBlockHelper m_MaterialPropertyBlockHelper;

		[SerializeField]
		[Tooltip("Shader property name to set the vector value of.")]
		private string m_Vector4PropertyName;

		private int m_Vector4Property;

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

		public string vector4PropertyName
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

		protected override void OnAffordanceValueUpdated(float4 newValue)
		{
		}

		protected override float4 GetCurrentValueForCapture()
		{
			return default(float4);
		}
	}
}
