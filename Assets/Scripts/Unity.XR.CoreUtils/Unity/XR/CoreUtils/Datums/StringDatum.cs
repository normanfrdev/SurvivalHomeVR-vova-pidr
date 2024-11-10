using UnityEngine;

namespace Unity.XR.CoreUtils.Datums
{
	[CreateAssetMenu(fileName = "StringDatum", menuName = "XR/Value Datums/String Datum", order = 0)]
	public class StringDatum : Datum<string>
	{
		public StringDatum()
		{
			((Datum<>)(object)this)._002Ector();
		}
	}
}
