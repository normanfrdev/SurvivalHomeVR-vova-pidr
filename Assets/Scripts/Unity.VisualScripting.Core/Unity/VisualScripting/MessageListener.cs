using System;
using UnityEngine;

namespace Unity.VisualScripting
{
	[DisableAnnotation]
	[AddComponentMenu("")]
	[IncludeInSettings(false)]
	public abstract class MessageListener : MonoBehaviour
	{
		private static Type[] _listenerTypes;

		[Obsolete("listenerTypes is deprecated", false)]
		public static Type[] listenerTypes => null;

		[Obsolete("Use the overload with a messageListenerType parameter instead", false)]
		public static void AddTo(GameObject gameObject)
		{
		}

		public static void AddTo(Type messageListenerType, GameObject gameObject)
		{
		}
	}
}
