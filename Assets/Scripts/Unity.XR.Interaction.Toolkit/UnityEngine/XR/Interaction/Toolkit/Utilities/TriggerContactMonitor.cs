using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace UnityEngine.XR.Interaction.Toolkit.Utilities
{
	internal class TriggerContactMonitor
	{
		private readonly Dictionary<Collider, IXRInteractable> m_EnteredColliders;

		private readonly HashSet<IXRInteractable> m_UnorderedInteractables;

		private readonly HashSet<Collider> m_EnteredUnassociatedColliders;

		private static readonly List<Collider> s_ScratchColliders;

		private static readonly List<Collider> s_ExitedColliders;

		public XRInteractionManager interactionManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public event Action<IXRInteractable> contactAdded
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

		public event Action<IXRInteractable> contactRemoved
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

		public void AddCollider(Collider collider)
		{
		}

		public void RemoveCollider(Collider collider)
		{
		}

		public void ResolveUnassociatedColliders()
		{
		}

		private void RemoveFromUnassociatedColliders(Collider col)
		{
		}

		public void ResolveUnassociatedColliders(IXRInteractable interactable)
		{
		}

		public void UpdateStayedColliders(HashSet<Collider> stayedColliders)
		{
		}

		public bool IsContacting(IXRInteractable interactable)
		{
			return false;
		}

		private static bool IsDestroyed(Collider col)
		{
			return false;
		}
	}
}
