using System;

namespace Unity.XR.CoreUtils.Bindings.Variables
{
	public class BindableVariableAlloc<T> : BindableVariableBase<T>
	{
		public BindableVariableAlloc(T initialValue = default(T), bool checkEquality = true, Func<T, T, bool> equalityMethod = null, bool startInitialized = false)
		{
			((BindableVariableBase<>)(object)this)._002Ector((T)default(T), checkEquality: false, (Func<T, T, bool>)null, startInitialized: false);
		}
	}
}
