using System;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using Unity.XR.CoreUtils;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives
{
	[AddComponentMenu("Affordance System/Receiver/Primitives/Color Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.ColorAffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class ColorAffordanceReceiver : BaseAsyncAffordanceStateReceiver<Color>
	{
		[SerializeField]
		[Tooltip("Color Affordance Theme datum property used to map affordance state to a color affordance value. Can store an asset or a serialized value.")]
		private ColorAffordanceThemeDatumProperty m_AffordanceThemeDatum;

		[SerializeField]
		[Tooltip("The event that is called when the current affordance value is updated.")]
		private ColorUnityEvent m_ValueUpdated;

		public ColorAffordanceThemeDatumProperty affordanceThemeDatum
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ColorUnityEvent valueUpdated
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override BaseAffordanceTheme<Color> defaultAffordanceTheme => null;

		protected override BindableVariable<Color> affordanceValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected override JobHandle ScheduleTweenJob(ref TweenJobData<Color> jobData)
		{
			return default(JobHandle);
		}

		protected override BaseAffordanceTheme<Color> GenerateNewAffordanceThemeInstance()
		{
			return null;
		}

		protected override void OnAffordanceValueUpdated(Color newValue)
		{
		}

		public ColorAffordanceReceiver()
		{
			((BaseAsyncAffordanceStateReceiver<>)(object)this)._002Ector();
		}
	}
}
