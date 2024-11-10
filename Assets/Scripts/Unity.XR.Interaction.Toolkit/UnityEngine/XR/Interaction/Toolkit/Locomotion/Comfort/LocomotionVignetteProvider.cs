using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort
{
	[Serializable]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class LocomotionVignetteProvider : ITunnelingVignetteProvider
	{
		[SerializeField]
		private LocomotionProvider m_LocomotionProvider;

		[SerializeField]
		private bool m_Enabled;

		[SerializeField]
		private bool m_OverrideDefaultParameters;

		[SerializeField]
		private VignetteParameters m_OverrideParameters;

		public LocomotionProvider locomotionProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool overrideDefaultParameters
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public VignetteParameters overrideParameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VignetteParameters vignetteParameters => null;
	}
}
