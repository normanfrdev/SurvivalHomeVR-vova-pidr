using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;

namespace Unity.VRTemplate
{
	public class AnchorVisuals : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The animation for the vertical glow element on the platform.")]
		private Animation m_FadeAnimation;

		[SerializeField]
		[Tooltip("The arrow transform, at the center of the platform.")]
		private Transform m_Arrow;

		[SerializeField]
		[Tooltip("Height of the arrow transform when teleport ray hovers the teleport pad.")]
		private float m_TargetArrowHeight;

		[SerializeField]
		[Tooltip("Animation duration of the arrow transform to and from the target arrow height.")]
		private float m_ArrowAnimationDuration;

		[SerializeField]
		[Tooltip("Animation curve of hte arrow transform to and from the target arrow height.")]
		private AnimationCurve m_AnimationCurve;

		private Coroutine m_ArrowCoroutine;

		private Vector3TweenableVariable m_ArrowHeight;

		private Vector3 m_InitialArrowScale;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void OnAnchorEnter()
		{
		}

		public void OnAnchorExit()
		{
		}

		public void HideArrowOnTeleport()
		{
		}
	}
}
