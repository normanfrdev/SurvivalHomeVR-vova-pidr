using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public abstract class LudiqScriptableObject : ScriptableObject, ISerializationCallbackReceiver
	{
		[SerializeField]
		[DoNotSerialize]
		protected SerializationData _data;

		internal event Action OnDestroyActions
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		protected virtual void OnBeforeSerialize()
		{
		}

		protected virtual void OnAfterSerialize()
		{
		}

		protected virtual void OnBeforeDeserialize()
		{
		}

		protected virtual void OnAfterDeserialize()
		{
		}

		protected virtual void OnPostDeserializeInEditor()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void ShowData()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
