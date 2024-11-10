using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Unity.VisualScripting
{
	public static class Serialization
	{
		public const string ConstructorWarning = "This parameterless constructor is only made public for serialization. Use another constructor instead.";

		private static readonly HashSet<SerializationOperation> freeOperations;

		private static readonly HashSet<SerializationOperation> busyOperations;

		private static readonly object @lock;

		private static readonly HashSet<ISerializationDepender> awaitingDependers;

		public static bool isUnitySerializing
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool isCustomSerializing => false;

		public static bool isSerializing => false;

		static Serialization()
		{
		}

		private static SerializationOperation StartOperation()
		{
			return null;
		}

		private static void EndOperation(SerializationOperation operation)
		{
		}

		public static T CloneViaSerialization<T>(this T value, bool forceReflected = false)
		{
			return default(T);
		}

		public static void CloneViaSerializationInto<TSource, TDestination>(this TSource value, ref TDestination instance, bool forceReflected = false) where TDestination : TSource
		{
		}

		public static SerializationData Serialize(this object value, bool forceReflected = false)
		{
			return default(SerializationData);
		}

		public static void DeserializeInto(this SerializationData data, ref object instance, bool forceReflected = false)
		{
		}

		public static object Deserialize(this SerializationData data, bool forceReflected = false)
		{
			return null;
		}

		private static string SerializeJson(fsSerializer serializer, object instance, bool forceReflected)
		{
			return null;
		}

		private static fsResult DeserializeJsonUtil(fsSerializer serializer, string json, ref object instance, bool forceReflected)
		{
			return default(fsResult);
		}

		private static void DeserializeJson(fsSerializer serializer, string json, ref object instance, bool forceReflected)
		{
		}

		private static void HandleResult(string label, fsResult result, Object context = null)
		{
		}

		public static string PrettyPrint(string json)
		{
			return null;
		}

		public static void AwaitDependencies(ISerializationDepender depender)
		{
		}

		public static void NotifyDependencyDeserializing(ISerializationDependency dependency)
		{
		}

		public static void NotifyDependencyDeserialized(ISerializationDependency dependency)
		{
		}

		public static void NotifyDependencyUnavailable(ISerializationDependency dependency)
		{
		}

		public static void NotifyDependencyAvailable(ISerializationDependency dependency)
		{
		}

		private static void CheckIfDependenciesMet(ISerializationDepender depender)
		{
		}

		public static void LogStuckDependers()
		{
		}
	}
}
