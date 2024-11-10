using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.CoreUtils.Collections
{
	[Serializable]
	public class SerializableDictionary<TKey, TValue> : Dictionary<TKey, TValue>, ISerializationCallbackReceiver
	{
		[Serializable]
		public struct Item
		{
			public TKey Key;

			public TValue Value;
		}

		[SerializeField]
		private List<Item> m_Items;

		public List<Item> SerializedItems => null;

		public SerializableDictionary()
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}

		public SerializableDictionary(IDictionary<TKey, TValue> input)
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}

		public virtual void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}
	}
}
