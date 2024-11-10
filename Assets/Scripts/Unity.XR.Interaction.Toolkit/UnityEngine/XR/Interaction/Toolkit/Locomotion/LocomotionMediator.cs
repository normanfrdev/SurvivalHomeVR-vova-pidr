using System.Collections.Generic;
using Unity.XR.CoreUtils;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion
{
	[AddComponentMenu("XR/Locomotion/Locomotion Mediator", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.LocomotionMediator.html")]
	[RequireComponent(typeof(XRBodyTransformer))]
	public class LocomotionMediator : MonoBehaviour
	{
		private class LocomotionProviderData
		{
			public LocomotionState state;

			public int locomotionEndFrame;
		}

		private XRBodyTransformer m_XRBodyTransformer;

		private readonly Dictionary<LocomotionProvider, LocomotionProviderData> m_ProviderDataMap;

		private static readonly List<LocomotionProvider> s_ProvidersToRemove;

		public XROrigin xrOrigin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected void Awake()
		{
		}

		protected void Update()
		{
		}

		internal bool TryPrepareLocomotion(LocomotionProvider provider)
		{
			return false;
		}

		internal bool TryStartLocomotion(LocomotionProvider provider)
		{
			return false;
		}

		private void StartLocomotion(LocomotionProvider provider, LocomotionProviderData providerData)
		{
		}

		internal bool TryEndLocomotion(LocomotionProvider provider)
		{
			return false;
		}

		public LocomotionState GetProviderLocomotionState(LocomotionProvider provider)
		{
			return default(LocomotionState);
		}
	}
}
