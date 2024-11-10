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
	[AddComponentMenu("Affordance System/Receiver/Primitives/Float Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.FloatAffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace has ")]
	public class FloatAffordanceReceiver : BaseAsyncAffordanceStateReceiver<float>
	{
		[SerializeField]
		[Tooltip("Float Affordance Theme datum property used to map affordance state to a float affordance value. Can store an asset or a serialized value.")]
		private FloatAffordanceThemeDatumProperty m_AffordanceThemeDatum;

		[SerializeField]
		[Tooltip("The event that is called when the current affordance value is updated.")]
		private FloatUnityEvent m_ValueUpdated;

		public FloatAffordanceThemeDatumProperty affordanceThemeDatum
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FloatUnityEvent valueUpdated
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override BaseAffordanceTheme<float> defaultAffordanceTheme => null;

		protected override BindableVariable<float> affordanceValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected override JobHandle ScheduleTweenJob(ref TweenJobData<float> jobData)
		{
			return default(JobHandle);
		}

		protected override BaseAffordanceTheme<float> GenerateNewAffordanceThemeInstance()
		{
			return null;
		}

		protected override void OnAffordanceValueUpdated(float newValue)
		{
		}

		public FloatAffordanceReceiver()
		{
			((BaseAsyncAffordanceStateReceiver<>)(object)this)._002Ector();
		}
	}
}
