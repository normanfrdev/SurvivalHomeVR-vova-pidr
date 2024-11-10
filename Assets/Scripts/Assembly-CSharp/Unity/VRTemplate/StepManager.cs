using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Unity.VRTemplate
{
	public class StepManager : MonoBehaviour
	{
		[Serializable]
		private class Step
		{
			[SerializeField]
			public GameObject stepObject;

			[SerializeField]
			public string buttonText;
		}

		[SerializeField]
		public TextMeshProUGUI m_StepButtonTextField;

		[SerializeField]
		private List<Step> m_StepList;

		private int m_CurrentStepIndex;

		public void Next()
		{
		}
	}
}
