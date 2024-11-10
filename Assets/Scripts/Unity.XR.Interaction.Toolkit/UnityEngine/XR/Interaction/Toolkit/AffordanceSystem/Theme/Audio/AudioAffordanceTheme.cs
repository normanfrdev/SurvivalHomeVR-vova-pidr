using System;
using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Audio
{
	[Serializable]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class AudioAffordanceTheme
	{
		[SerializeField]
		private List<AudioAffordanceThemeData> m_List;

		protected AudioAffordanceTheme()
		{
		}

		internal void ValidateTheme()
		{
		}

		public AudioAffordanceThemeData GetAffordanceThemeDataForIndex(byte stateIndex)
		{
			return null;
		}
	}
}
