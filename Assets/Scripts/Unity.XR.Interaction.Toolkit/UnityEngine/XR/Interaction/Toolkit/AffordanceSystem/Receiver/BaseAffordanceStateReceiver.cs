using System;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class BaseAffordanceStateReceiver<T> : MonoBehaviour, IAffordanceStateReceiver<T>, IAffordanceStateReceiver where T : struct, IEquatable<T>
	{
		[SerializeField]
		[Tooltip("Affordance state provider component to subscribe to.")]
		private BaseAffordanceStateProvider m_AffordanceStateProvider;

		[SerializeField]
		[Tooltip("If true, the initial captured state value for the receiver will replace the idle value in the affordance theme.")]
		private bool m_ReplaceIdleStateValueWithInitialValue;

		private BaseAffordanceTheme<T> m_AffordanceTheme;

		private readonly BindableVariable<AffordanceStateData> m_AffordanceStateData;

		private bool m_Initialized;

		public BaseAffordanceStateProvider affordanceStateProvider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool replaceIdleStateValueWithInitialValue
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public BaseAffordanceTheme<T> affordanceTheme
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected abstract BaseAffordanceTheme<T> defaultAffordanceTheme { get; }

		protected abstract BindableVariable<T> affordanceValue { get; }

		public IReadOnlyBindableVariable<T> currentAffordanceValue => null;

		public IReadOnlyBindableVariable<AffordanceStateData> currentAffordanceStateData => null;

		protected T initialValue
		{
			[CompilerGenerated]
			get
			{
				return default(T);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool initialValueCaptured
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

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Start()
		{
		}

		private void Initialize()
		{
		}

		protected abstract BaseAffordanceTheme<T> GenerateNewAffordanceThemeInstance();

		protected virtual void OnAffordanceThemeChanged(BaseAffordanceTheme<T> newValue)
		{
		}

		private void LogIfMissingAffordanceStates(BaseAffordanceTheme<T> theme)
		{
		}

		public virtual void OnAffordanceStateUpdated(AffordanceStateData previousState, AffordanceStateData newState)
		{
		}

		protected virtual void ConsumeAffordance(T newValue)
		{
		}

		protected abstract void OnAffordanceValueUpdated(T newValue);

		protected virtual void CaptureInitialValue()
		{
		}

		protected virtual T GetCurrentValueForCapture()
		{
			return default(T);
		}

		protected virtual T ProcessTargetAffordanceValue(T newValue)
		{
			return default(T);
		}
	}
}
