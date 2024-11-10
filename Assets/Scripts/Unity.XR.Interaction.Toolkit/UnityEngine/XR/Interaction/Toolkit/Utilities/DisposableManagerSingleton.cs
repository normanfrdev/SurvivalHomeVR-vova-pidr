using System;
using Unity.XR.CoreUtils.Collections;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	[AddComponentMenu("")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Utilities.DisposableManagerSingleton.html")]
	internal sealed class DisposableManagerSingleton : MonoBehaviour
	{
		private static DisposableManagerSingleton s_DisposableManagerSingleton;

		private readonly HashSetList<IDisposable> m_Disposables;

		private static DisposableManagerSingleton instance => null;

		private static DisposableManagerSingleton Initialize()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void DisposeAll()
		{
		}

		public static void RegisterDisposable(IDisposable disposableToRegister)
		{
		}
	}
}
