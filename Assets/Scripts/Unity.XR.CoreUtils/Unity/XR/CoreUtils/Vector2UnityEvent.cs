using System;
using UnityEngine;
using UnityEngine.Events;

namespace Unity.XR.CoreUtils
{
	[Serializable]
	public class Vector2UnityEvent : UnityEvent<Vector2>
	{
		public Vector2UnityEvent()
		{
			((UnityEvent<T0>)(object)this)._002Ector();
		}
	}
}
