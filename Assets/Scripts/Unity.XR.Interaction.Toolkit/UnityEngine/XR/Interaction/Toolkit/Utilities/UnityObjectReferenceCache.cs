namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal class UnityObjectReferenceCache<T> where T : Object
	{
		private T m_CapturedField;

		private T m_FieldOrNull;

		public bool TryGet(T field, out T fieldOrNull)
		{
			fieldOrNull = null;
			return false;
		}
	}
	internal class UnityObjectReferenceCache<TInterface, TObject> where TInterface : class where TObject : Object
	{
		private TObject m_CapturedObject;

		private TInterface m_Interface;

		public TInterface Get(TObject field)
		{
			return null;
		}

		public void Set(ref TObject field, TInterface value)
		{
		}
	}
}
