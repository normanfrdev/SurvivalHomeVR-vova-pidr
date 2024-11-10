using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.core-utils@2.0/api/Unity.XR.CoreUtils.OnDestroyNotifier.html")]
	public class OnDestroyNotifier : MonoBehaviour
	{
		public Action<OnDestroyNotifier> Destroyed
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private void OnDestroy()
		{
		}
	}
}
