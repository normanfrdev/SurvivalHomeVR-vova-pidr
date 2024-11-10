using UnityEngine;

namespace Unity.XR.CoreUtils.Datums
{
	[CreateAssetMenu(fileName = "FloatDatum", menuName = "XR/Value Datums/Float Datum", order = 0)]
	public class FloatDatum : Datum<float>
	{
		public FloatDatum()
		{
			((Datum<>)(object)this)._002Ector();
		}
	}
}
