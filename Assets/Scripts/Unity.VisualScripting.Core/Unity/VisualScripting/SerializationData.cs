using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[Serializable]
	public struct SerializationData
	{
		[SerializeField]
		private string _json;

		[SerializeField]
		private UnityEngine.Object[] _objectReferences;

		public string json => null;

		public UnityEngine.Object[] objectReferences => null;

		public SerializationData(string json, IEnumerable<UnityEngine.Object> objectReferences)
		{
		}

		public SerializationData(string json, params UnityEngine.Object[] objectReferences)
		{
		}

		internal void Clear()
		{
		}

		public string ToString(string title)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public void ShowString(string title = null)
		{
		}
	}
}
