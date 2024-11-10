using System;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.XR.CoreUtils
{
	[Serializable]
	public class QuaternionUnityEvent : UnityEvent<Quaternion>
	{
		public QuaternionUnityEvent()
		{
			((UnityEvent<T0>)(object)this)._002Ector();
		}
	}
}
