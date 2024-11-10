using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.PXR
{
	public sealed class PXR_PlatformSetting : ScriptableObject
	{
		public enum simulationType
		{
			Null = 0,
			Invalid = 1,
			Valid = 2
		}

		[SerializeField]
		public bool entitlementCheckSimulation;

		[SerializeField]
		public bool startTimeEntitlementCheck;

		[SerializeField]
		public string appID;

		[SerializeField]
		public bool useHighlight;

		public List<string> deviceSN;

		private static PXR_PlatformSetting instance;

		public static PXR_PlatformSetting Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
