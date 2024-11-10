using System;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class IntCallback : AndroidJavaProxy
	{
		public Action<int> mCallback;

		public IntCallback(Action<int> callback)
			: base((string)null)
		{
		}

		public void CallBack(int var1)
		{
		}
	}
}
