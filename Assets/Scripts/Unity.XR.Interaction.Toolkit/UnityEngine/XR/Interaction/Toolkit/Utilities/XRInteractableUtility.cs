using System;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	public static class XRInteractableUtility
	{
		internal struct AllowTriggerCollidersScope : IDisposable
		{
			private bool m_Disposed;

			private readonly bool m_OldValue;

			public AllowTriggerCollidersScope(bool newAllowTriggerColliders)
			{
			}

			public void Dispose()
			{
			}
		}

		private static bool allowTriggerColliders
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool TryGetClosestCollider(IXRInteractable interactable, Vector3 position, out DistanceInfo distanceInfo)
		{
			distanceInfo = default(DistanceInfo);
			return false;
		}

		public static bool TryGetClosestPointOnCollider(IXRInteractable interactable, Vector3 position, out DistanceInfo distanceInfo)
		{
			distanceInfo = default(DistanceInfo);
			return false;
		}
	}
}
