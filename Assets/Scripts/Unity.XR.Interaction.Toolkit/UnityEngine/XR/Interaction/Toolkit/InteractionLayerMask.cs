using System;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Serializable]
	public struct InteractionLayerMask : ISerializationCallbackReceiver
	{
		[SerializeField]
		private uint m_Bits;

		private int m_Mask;

		public int value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static implicit operator int(InteractionLayerMask mask)
		{
			return 0;
		}

		public static implicit operator InteractionLayerMask(int intVal)
		{
			return default(InteractionLayerMask);
		}

		public static string LayerToName(int layer)
		{
			return null;
		}

		public static int NameToLayer(string layerName)
		{
			return 0;
		}

		public static int GetMask(params string[] layerNames)
		{
			return 0;
		}

		public void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}
	}
}
