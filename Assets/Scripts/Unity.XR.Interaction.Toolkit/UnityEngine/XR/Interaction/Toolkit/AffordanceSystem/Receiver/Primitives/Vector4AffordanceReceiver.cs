using System;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.XR.CoreUtils;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Jobs;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives
{
	[AddComponentMenu("Affordance System/Receiver/Primitives/Vector4 Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.Vector4AffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class Vector4AffordanceReceiver : BaseAsyncAffordanceStateReceiver<float4>
	{
		[SerializeField]
		[Tooltip("Vector4 Affordance Theme datum property used to map affordance state to a Vector4 affordance value. Can store an asset or a serialized value.")]
		private Vector4AffordanceThemeDatumProperty m_AffordanceThemeDatum;

		[SerializeField]
		[Tooltip("The event that is called when the current affordance value is updated.")]
		private Vector4UnityEvent m_ValueUpdated;

		public Vector4AffordanceThemeDatumProperty affordanceThemeDatum
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector4UnityEvent valueUpdated
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override BaseAffordanceTheme<float4> defaultAffordanceTheme => null;

		protected override BindableVariable<float4> affordanceValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected override JobHandle ScheduleTweenJob(ref TweenJobData<float4> jobData)
		{
			return default(JobHandle);
		}

		protected override BaseAffordanceTheme<float4> GenerateNewAffordanceThemeInstance()
		{
			return null;
		}

		protected override void OnAffordanceValueUpdated(float4 newValue)
		{
		}

		public Vector4AffordanceReceiver()
		{
			((BaseAsyncAffordanceStateReceiver<>)(object)this)._002Ector();
		}
	}
}
