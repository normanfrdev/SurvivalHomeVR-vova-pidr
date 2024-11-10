using System;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class FileCopyCallback : AndroidJavaProxy
	{
		public Action mOnCopyStart;

		public Action<double> mOnCopyProgress;

		public Action<int> mOnCopyFinish;

		public FileCopyCallback(Action onCopyStart, Action<double> onCopyProgress, Action<int> onCopyFinish)
			: base((string)null)
		{
		}

		public void OnCopyStart()
		{
		}

		public void OnCopyProgress(double var1)
		{
		}

		public void OnCopyFinish(int var1)
		{
		}
	}
}
