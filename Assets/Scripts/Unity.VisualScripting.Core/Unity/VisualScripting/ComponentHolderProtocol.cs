using System;
using UnityEngine;

namespace Unity.VisualScripting
{
	public static class ComponentHolderProtocol
	{
		public static bool IsComponentHolderType(Type type)
		{
			return false;
		}

		public static bool IsComponentHolder(this UnityEngine.Object uo)
		{
			return false;
		}

		public static GameObject GameObject(this UnityEngine.Object uo)
		{
			return null;
		}

		public static T AddComponent<T>(this UnityEngine.Object uo) where T : Component
		{
			return null;
		}

		public static T GetOrAddComponent<T>(this UnityEngine.Object uo) where T : Component
		{
			return null;
		}

		public static T GetComponent<T>(this UnityEngine.Object uo)
		{
			return default(T);
		}

		public static T GetComponentInChildren<T>(this UnityEngine.Object uo)
		{
			return default(T);
		}

		public static T GetComponentInParent<T>(this UnityEngine.Object uo)
		{
			return default(T);
		}

		public static T[] GetComponents<T>(this UnityEngine.Object uo)
		{
			return null;
		}

		public static T[] GetComponentsInChildren<T>(this UnityEngine.Object uo)
		{
			return null;
		}

		public static T[] GetComponentsInParent<T>(this UnityEngine.Object uo)
		{
			return null;
		}

		public static Component GetComponent(this UnityEngine.Object uo, Type type)
		{
			return null;
		}

		public static Component GetComponentInChildren(this UnityEngine.Object uo, Type type)
		{
			return null;
		}

		public static Component GetComponentInParent(this UnityEngine.Object uo, Type type)
		{
			return null;
		}

		public static Component[] GetComponents(this UnityEngine.Object uo, Type type)
		{
			return null;
		}

		public static Component[] GetComponentsInChildren(this UnityEngine.Object uo, Type type)
		{
			return null;
		}

		public static Component[] GetComponentsInParent(this UnityEngine.Object uo, Type type)
		{
			return null;
		}
	}
}
