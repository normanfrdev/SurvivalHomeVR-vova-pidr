using System;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering
{
	[AddComponentMenu("Affordance System/Receiver/Rendering/Blend Shape Affordance Receiver", 12)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Rendering.BlendShapeAffordanceReceiver.html")]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class BlendShapeAffordanceReceiver : FloatAffordanceReceiver
	{
		[SerializeField]
		[Tooltip("Skinned Mesh Renderer to apply blend shapes animations to.")]
		private SkinnedMeshRenderer m_SkinnedMeshRenderer;

		[SerializeField]
		[Tooltip("BlendShape index to animate.")]
		private int m_BlendShapeIndex;

		public SkinnedMeshRenderer skinnedMeshRenderer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int blendShapeIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnAffordanceValueUpdated(float newValue)
		{
		}

		protected override float GetCurrentValueForCapture()
		{
			return 0f;
		}
	}
}
