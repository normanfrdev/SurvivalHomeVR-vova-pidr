using System;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class BoolCallback : AndroidJavaProxy
	{
		public Action<bool> mCallback;

		public BoolCallback(Action<bool> callback)
			: base((string)null)
		{
		}

		public void CallBack(bool var1)
		{
		}
	}
}
