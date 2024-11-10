using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PICO.TOBSupport
{
	public class MarkerInfoCallback : AndroidJavaProxy
	{
		public Action<List<MarkerInfo>> mCallback;

		private List<MarkerInfo> mlist;

		private TrackingOriginModeFlags TrackingMode;

		private float YOffset;

		public MarkerInfoCallback(TrackingOriginModeFlags trackingMode, float cameraYOffset, Action<List<MarkerInfo>> callback)
			: base((string)null)
		{
		}

		public void CallBack(string var1)
		{
		}

		public List<MarkerInfo> JsonToMarkerInfos(string json)
		{
			return null;
		}
	}
}
