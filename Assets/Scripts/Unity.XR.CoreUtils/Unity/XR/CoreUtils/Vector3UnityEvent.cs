using System;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.XR.CoreUtils
{
	[Serializable]
	public class Vector3UnityEvent : UnityEvent<Vector3>
	{
		public Vector3UnityEvent()
		{
			((UnityEvent<T0>)(object)this)._002Ector();
		}
	}
}
