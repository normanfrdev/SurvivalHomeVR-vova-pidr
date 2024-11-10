using System;
using Unity.XR.CoreUtils.Datums;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives
{
	[Serializable]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class FloatAffordanceThemeDatumProperty : DatumProperty<FloatAffordanceTheme, FloatAffordanceThemeDatum>
	{
		public FloatAffordanceThemeDatumProperty(FloatAffordanceTheme value)
		{
			((DatumProperty<TValue, TDatum>)(object)this)._002Ector();
		}

		public FloatAffordanceThemeDatumProperty(FloatAffordanceThemeDatum datum)
		{
			((DatumProperty<TValue, TDatum>)(object)this)._002Ector();
		}
	}
}
