using UnityEngine;

namespace Unity.XR.CoreUtils.Datums
{
	[CreateAssetMenu(fileName = "IntDatum", menuName = "XR/Value Datums/Int Datum", order = 0)]
	public class IntDatum : Datum<int>
	{
		public void SetValueRounded(float value)
		{
		}

		public IntDatum()
		{
			((Datum<>)(object)this)._002Ector();
		}
	}
}
