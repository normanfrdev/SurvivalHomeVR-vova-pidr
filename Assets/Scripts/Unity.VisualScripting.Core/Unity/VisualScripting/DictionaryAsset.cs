using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[IncludeInSettings(false)]
	public sealed class DictionaryAsset : LudiqScriptableObject, IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
	{
		public object this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Serialize]
		public Dictionary<string, object> dictionary
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Count => 0;

		public ICollection<string> Keys => null;

		public ICollection<object> Values => null;

		bool ICollection<KeyValuePair<string, object>>.IsReadOnly => false;

		protected override void OnAfterDeserialize()
		{
		}

		public void Clear()
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public void Add(string key, object value)
		{
		}

		public void Merge(DictionaryAsset other, bool overwriteExisting = true)
		{
		}

		public bool Remove(string key)
		{
			return false;
		}

		public bool TryGetValue(string key, out object value)
		{
			value = null;
			return false;
		}

		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item)
		{
		}

		bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
		{
			return false;
		}

		void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
		{
		}

		bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
		{
			return false;
		}

		[ContextMenu("Show Data...")]
		protected override void ShowData()
		{
		}
	}
}
