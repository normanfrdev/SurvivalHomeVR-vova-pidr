using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Serialization;

namespace UnityEngine.XR.Management
{
	public sealed class XRManagerSettings : ScriptableObject
	{
		[CompilerGenerated]
		private sealed class _003CInitializeLoader_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public XRManagerSettings _003C_003E4__this;

			private List<XRLoader>.Enumerator _003C_003E7__wrap1;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitializeLoader_003Ed__24(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[HideInInspector]
		private bool m_InitializationComplete;

		[HideInInspector]
		[SerializeField]
		private bool m_RequiresSettingsUpdate;

		[SerializeField]
		[Tooltip("Determines if the XR Manager instance is responsible for creating and destroying the appropriate loader instance.")]
		[FormerlySerializedAs("AutomaticLoading")]
		private bool m_AutomaticLoading;

		[SerializeField]
		[Tooltip("Determines if the XR Manager instance is responsible for starting and stopping subsystems for the active loader instance.")]
		[FormerlySerializedAs("AutomaticRunning")]
		private bool m_AutomaticRunning;

		[SerializeField]
		[Tooltip("List of XR Loader instances arranged in desired load order.")]
		[FormerlySerializedAs("Loaders")]
		private List<XRLoader> m_Loaders;

		[SerializeField]
		[HideInInspector]
		private HashSet<XRLoader> m_RegisteredLoaders;

		public bool automaticLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool automaticRunning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("'XRManagerSettings.loaders' property is obsolete. Use 'XRManagerSettings.activeLoaders' instead to get a list of the current loaders.")]
		public List<XRLoader> loaders => null;

		public IReadOnlyList<XRLoader> activeLoaders => null;

		public bool isInitializationComplete => false;

		[HideInInspector]
		public XRLoader activeLoader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal List<XRLoader> currentLoaders
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal HashSet<XRLoader> registeredLoaders => null;

		public T ActiveLoaderAs<T>() where T : XRLoader
		{
			return null;
		}

		public void InitializeLoaderSync()
		{
		}

		[IteratorStateMachine(typeof(_003CInitializeLoader_003Ed__24))]
		public IEnumerator InitializeLoader()
		{
			return null;
		}

		public bool TryAddLoader(XRLoader loader, int index = -1)
		{
			return false;
		}

		public bool TryRemoveLoader(XRLoader loader)
		{
			return false;
		}

		public bool TrySetLoaders(List<XRLoader> reorderedLoaders)
		{
			return false;
		}

		private void Awake()
		{
		}

		private bool CheckGraphicsAPICompatibility(XRLoader loader)
		{
			return false;
		}

		public void StartSubsystems()
		{
		}

		public void StopSubsystems()
		{
		}

		public void DeinitializeLoader()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
