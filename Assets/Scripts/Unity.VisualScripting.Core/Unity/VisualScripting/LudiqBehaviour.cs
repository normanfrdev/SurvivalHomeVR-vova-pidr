using UnityEngine;

namespace Unity.VisualScripting
{
	public abstract class LudiqBehaviour : MonoBehaviour, ISerializationCallbackReceiver
	{
		[SerializeField]
		[DoNotSerialize]
		protected SerializationData _data;

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

		protected virtual void ShowData()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
