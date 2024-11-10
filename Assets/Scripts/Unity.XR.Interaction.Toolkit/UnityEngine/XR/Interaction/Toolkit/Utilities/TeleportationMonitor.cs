using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Locomotion;
using UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal class TeleportationMonitor
	{
		private Dictionary<TeleportationProvider, List<IXRInteractor>> m_TeleportInteractors;

		private Dictionary<LocomotionMediator, Pose> m_OriginPosesBeforeTeleport;

		private static readonly LinkedPool<Dictionary<TeleportationProvider, List<IXRInteractor>>> s_TeleportInteractorsPool;

		private static readonly LinkedPool<Dictionary<LocomotionMediator, Pose>> s_OriginPosesBeforeTeleportPool;

		private static TeleportationProvider[] s_TeleportationProvidersCache;

		public event Action<Pose> teleported
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void AddInteractor(IXRInteractor interactor)
		{
		}

		public void RemoveInteractor(IXRInteractor interactor)
		{
		}

		private static bool TryGetOriginTransform(LocomotionProvider locomotionProvider, out Transform originTransform)
		{
			originTransform = null;
			return false;
		}

		private static bool TryGetOriginTransform(LocomotionMediator mediator, out Transform originTransform)
		{
			originTransform = null;
			return false;
		}

		private static bool FindTeleportationProviders()
		{
			return false;
		}

		private void OnBeginTeleportation(LocomotionProvider provider)
		{
		}

		private void OnEndTeleportation(LocomotionProvider provider)
		{
		}
	}
}
