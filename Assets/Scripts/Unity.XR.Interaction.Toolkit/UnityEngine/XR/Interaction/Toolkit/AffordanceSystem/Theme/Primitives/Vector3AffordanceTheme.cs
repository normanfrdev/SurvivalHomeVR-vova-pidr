using System;
using Unity.Mathematics;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives
{
	[Serializable]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class Vector3AffordanceTheme : BaseAffordanceTheme<float3>
	{
		public Vector3AffordanceTheme()
		{
			((BaseAffordanceTheme<>)(object)this)._002Ector();
		}
	}
}
