using System;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Transformation
{
	[AddComponentMenu("Affordance System/Receiver/Transformation/Uniform Transform Scale Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Transformation.UniformTransformScaleAffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class UniformTransformScaleAffordanceReceiver : FloatAffordanceReceiver
	{
		[SerializeField]
		[Tooltip("Transform on which to apply scale value.")]
		private Transform m_TransformToScale;

		private bool m_HasTransformToScale;

		private Vector3 m_InitialScale;

		public Transform transformToScale
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override float GetCurrentValueForCapture()
		{
			return 0f;
		}

		protected override void OnAffordanceValueUpdated(float newValue)
		{
		}

		private void OnValidate()
		{
		}
	}
}
