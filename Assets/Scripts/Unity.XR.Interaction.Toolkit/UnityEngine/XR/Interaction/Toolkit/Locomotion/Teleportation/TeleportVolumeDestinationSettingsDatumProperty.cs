using System;
using Unity.XR.CoreUtils.Datums;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[Serializable]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class TeleportVolumeDestinationSettingsDatumProperty : DatumProperty<TeleportVolumeDestinationSettings, TeleportVolumeDestinationSettingsDatum>
	{
		public TeleportVolumeDestinationSettingsDatumProperty(TeleportVolumeDestinationSettings value)
		{
			((DatumProperty<TValue, TDatum>)(object)this)._002Ector();
		}

		public TeleportVolumeDestinationSettingsDatumProperty(TeleportVolumeDestinationSettingsDatum datum)
		{
			((DatumProperty<TValue, TDatum>)(object)this)._002Ector();
		}
	}
}
