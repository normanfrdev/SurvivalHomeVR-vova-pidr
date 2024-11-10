using System;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering
{
	[AddComponentMenu("Affordance System/Receiver/Rendering/Float Material Property Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.FloatMaterialPropertyAffordanceReceiver.html")]
	[RequireComponent(typeof(MaterialPropertyBlockHelper))]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class FloatMaterialPropertyAffordanceReceiver : FloatAffordanceReceiver
	{
		[SerializeField]
		[Tooltip("Material Property Block Helper component reference used to set material properties.")]
		private MaterialPropertyBlockHelper m_MaterialPropertyBlockHelper;

		[SerializeField]
		[Tooltip("Shader property name to set the float value of.")]
		private string m_FloatPropertyName;

		private int m_FloatProperty;

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

		public string floatPropertyName
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

		protected override void OnAffordanceValueUpdated(float newValue)
		{
		}

		protected override float GetCurrentValueForCapture()
		{
			return 0f;
		}
	}
}
