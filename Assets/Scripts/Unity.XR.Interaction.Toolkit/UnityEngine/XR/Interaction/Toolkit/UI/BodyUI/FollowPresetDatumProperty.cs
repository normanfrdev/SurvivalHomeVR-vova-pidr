using System;
using Unity.XR.CoreUtils.Datums;

namespace UnityEngine.XR.Interaction.Toolkit.UI.BodyUI
{
	[Serializable]
	public class FollowPresetDatumProperty : DatumProperty<FollowPreset, FollowPresetDatum>
	{
		public FollowPresetDatumProperty(FollowPreset value)
		{
			((DatumProperty<TValue, TDatum>)(object)this)._002Ector();
		}

		public FollowPresetDatumProperty(FollowPresetDatum datum)
		{
			((DatumProperty<TValue, TDatum>)(object)this)._002Ector();
		}
	}
}
