using System;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class StringCallback : AndroidJavaProxy
	{
		public Action<string> mCallback;

		public StringCallback(Action<string> callback)
			: base((string)null)
		{
		}

		public void CallBack(string var1)
		{
		}
	}
}
