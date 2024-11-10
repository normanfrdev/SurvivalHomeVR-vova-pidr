using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	public static class EventBus
	{
		private static readonly Dictionary<EventHook, HashSet<Delegate>> events;

		internal static Dictionary<EventHook, HashSet<Delegate>> testAccessEvents => null;

		static EventBus()
		{
		}

		public static void Register<TArgs>(EventHook hook, Action<TArgs> handler)
		{
		}

		public static void Unregister(EventHook hook, Delegate handler)
		{
		}

		public static void Trigger<TArgs>(EventHook hook, TArgs args)
		{
		}

		public static void Trigger<TArgs>(string name, GameObject target, TArgs args)
		{
		}

		public static void Trigger(EventHook hook)
		{
		}

		public static void Trigger(string name, GameObject target)
		{
		}
	}
}
