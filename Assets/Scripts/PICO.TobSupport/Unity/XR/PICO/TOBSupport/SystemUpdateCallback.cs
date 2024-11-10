using System;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class SystemUpdateCallback : AndroidJavaProxy
	{
		public Action<int, float> OnUpdateStatusChanged;

		public Action<int, string> OnUpdateComplete;

		public SystemUpdateCallback(Action<int, float> onUpdateStatusChanged, Action<int, string> onUpdateComplete)
			: base((string)null)
		{
		}

		public void onUpdateStatusChanged(int statusCode, float percent)
		{
		}

		public void onUpdateComplete(int errorCode, string errorMsg)
		{
		}
	}
}
