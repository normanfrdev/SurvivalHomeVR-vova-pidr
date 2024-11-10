using System;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class BindCallback : AndroidJavaProxy
	{
		public Action<bool> mCallback;

		public BindCallback(Action<bool> callback)
			: base((string)null)
		{
		}

		public void CallBack(bool var1)
		{
		}
	}
}
