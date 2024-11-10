using System;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	[Serializable]
	public sealed class InputFeatureUsageString<T> where T : struct
	{
		[SerializeField]
		private string m_Name;

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public InputFeatureUsageString()
		{
		}

		public InputFeatureUsageString(string usageName)
		{
		}
	}
}
