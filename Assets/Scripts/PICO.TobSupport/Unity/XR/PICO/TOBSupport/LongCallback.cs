using System;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class LongCallback : AndroidJavaProxy
	{
		public Action<long> mCallback;

		public LongCallback(Action<long> callback)
			: base((string)null)
		{
		}

		public void CallBack(long var1)
		{
		}
	}
}
