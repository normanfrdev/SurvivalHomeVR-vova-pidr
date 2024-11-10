using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.PICO.TOBSupport
{
	public class PXR_EnterpriseTools : MonoBehaviour
	{
		public struct NoDelayedQueueItem
		{
			public Action action;
		}

		private List<NoDelayedQueueItem> _actions;

		private List<NoDelayedQueueItem> _currentActions;

		private static PXR_EnterpriseTools instance;

		public static PXR_EnterpriseTools Instance => null;

		public void StartUp()
		{
		}

		public static void QueueOnMainThread(Action taction)
		{
		}

		private void Update()
		{
		}
	}
}
