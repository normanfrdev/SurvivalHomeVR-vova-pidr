using System;
using Unity.XR.CoreUtils.Datums;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives
{
	[CreateAssetMenu(fileName = "Vector4AffordanceTheme", menuName = "Affordance Theme/Vector4 Affordance Theme", order = 0)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives.Vector4AffordanceThemeDatum.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class Vector4AffordanceThemeDatum : Datum<Vector4AffordanceTheme>
	{
		public Vector4AffordanceThemeDatum()
		{
			((Datum<T>)(object)this)._002Ector();
		}
	}
}
