using System;
using Unity.XR.CoreUtils.Datums;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives
{
	[CreateAssetMenu(fileName = "FloatAffordanceTheme", menuName = "Affordance Theme/Float Affordance Theme", order = 0)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives.FloatAffordanceThemeDatum.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class FloatAffordanceThemeDatum : Datum<FloatAffordanceTheme>
	{
		public FloatAffordanceThemeDatum()
		{
			((Datum<T>)(object)this)._002Ector();
		}
	}
}
