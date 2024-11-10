using System;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering
{
	[AddComponentMenu("Affordance System/Rendering/Material Instance Helper", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering.MaterialInstanceHelper.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class MaterialInstanceHelper : MaterialHelperBase
	{
		private Material m_MaterialInstance;

		protected void OnDestroy()
		{
		}

		public bool TryGetMaterialInstance(out Material materialInstance)
		{
			materialInstance = null;
			return false;
		}

		protected override void Initialize()
		{
		}
	}
}
