using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine;

namespace Unity.XR.CoreUtils.Datums
{
	public abstract class Datum<T> : ScriptableObject
	{
		[Multiline]
		[SerializeField]
		private string m_Comments;

		[SerializeField]
		private bool m_ReadOnly;

		[SerializeField]
		private T m_Value;

		private readonly BindableVariableAlloc<T> m_BindableVariableReference;

		public string Comments
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IReadOnlyBindableVariable<T> BindableVariableReference => null;

		public T Value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		protected void OnEnable()
		{
		}
	}
}
