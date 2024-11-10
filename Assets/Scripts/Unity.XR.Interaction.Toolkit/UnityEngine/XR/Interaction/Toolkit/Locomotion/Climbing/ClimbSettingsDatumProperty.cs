using System;
using Unity.XR.CoreUtils.Datums;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing
{
	[Serializable]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class ClimbSettingsDatumProperty : DatumProperty<ClimbSettings, ClimbSettingsDatum>
	{
		public ClimbSettingsDatumProperty(ClimbSettings value)
		{
			((DatumProperty<TValue, TDatum>)(object)this)._002Ector();
		}

		public ClimbSettingsDatumProperty(ClimbSettingsDatum datum)
		{
			((DatumProperty<TValue, TDatum>)(object)this)._002Ector();
		}
	}
}
