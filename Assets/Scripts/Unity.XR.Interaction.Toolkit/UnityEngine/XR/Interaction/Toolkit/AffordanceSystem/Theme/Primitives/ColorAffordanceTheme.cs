using System;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives
{
	[Serializable]
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public class ColorAffordanceTheme : BaseAffordanceTheme<Color>
	{
		[Header("Color Blend Configuration")]
		[SerializeField]
		[Tooltip("- Solid: Replaces the target value directly.\n- Add: Adds initial color to target color.\n- Mix: Blends initial and target color.")]
		private ColorBlendMode m_ColorBlendMode;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Value between 0 and 1 used to compute color blend modes.")]
		private float m_BlendAmount;

		public ColorBlendMode colorBlendMode
		{
			get
			{
				return default(ColorBlendMode);
			}
			set
			{
			}
		}

		public float blendAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override void CopyFrom(BaseAffordanceTheme<Color> other)
		{
		}

		public ColorAffordanceTheme()
		{
			((BaseAffordanceTheme<>)(object)this)._002Ector();
		}
	}
}
