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
	[AddComponentMenu("Affordance System/Receiver/Primitives/Vector3 Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives.Vector3AffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class Vector3AffordanceReceiver : BaseAsyncAffordanceStateReceiver<float3>
	{
		[SerializeField]
		[Tooltip("Vector3 Affordance Theme datum property used to map affordance state to a Vector3 affordance value. Can store an asset or a serialized value.")]
		private Vector3AffordanceThemeDatumProperty m_AffordanceThemeDatum;

		[SerializeField]
		[Tooltip("The event that is called when the current affordance value is updated.")]
		private Vector3UnityEvent m_ValueUpdated;

		public Vector3AffordanceThemeDatumProperty affordanceThemeDatum
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3UnityEvent valueUpdated
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override BaseAffordanceTheme<float3> defaultAffordanceTheme => null;

		protected override BindableVariable<float3> affordanceValue
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected override JobHandle ScheduleTweenJob(ref TweenJobData<float3> jobData)
		{
			return default(JobHandle);
		}

		protected override BaseAffordanceTheme<float3> GenerateNewAffordanceThemeInstance()
		{
			return null;
		}

		protected override void OnAffordanceValueUpdated(float3 newValue)
		{
		}

		public Vector3AffordanceReceiver()
		{
			((BaseAsyncAffordanceStateReceiver<>)(object)this)._002Ector();
		}
	}
}
