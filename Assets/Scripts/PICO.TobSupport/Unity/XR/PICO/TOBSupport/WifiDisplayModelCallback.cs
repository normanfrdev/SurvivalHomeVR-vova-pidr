using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class WifiDisplayModelCallback : AndroidJavaProxy
	{
		public Action<List<WifiDisplayModel>> mCallback;

		public WifiDisplayModelCallback(Action<List<WifiDisplayModel>> callback)
			: base((string)null)
		{
		}

		public void CallBack(string var1)
		{
		}

		public List<WifiDisplayModel> JsonToWifiDisplayModel(string json)
		{
			return null;
		}
	}
}
