using System;
using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/Locomotion/Legacy/Continuous Turn Provider (Device-based)", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.DeviceBasedContinuousTurnProvider.html")]
	[Obsolete("DeviceBasedContinuousTurnProvider has been deprecated in version 3.0.0. Use ContinuousTurnProvider instead.")]
	public class DeviceBasedContinuousTurnProvider : ContinuousTurnProviderBase
	{
		public enum InputAxes
		{
			Primary2DAxis = 0,
			Secondary2DAxis = 1
		}

		[SerializeField]
		[Tooltip("The 2D Input Axis on the controller devices that will be used to trigger a turn.")]
		private InputAxes m_InputBinding;

		[SerializeField]
		[Tooltip("A list of controllers that allow Turn.  If an XRController is not enabled, or does not have input actions enabled, turn will not work.")]
		private List<XRBaseController> m_Controllers;

		[SerializeField]
		[Tooltip("Value below which input values will be clamped. After clamping, values will be renormalized to [0, 1] between min and max.")]
		private float m_DeadzoneMin;

		[SerializeField]
		[Tooltip("Value above which input values will be clamped. After clamping, values will be renormalized to [0, 1] between min and max.")]
		private float m_DeadzoneMax;

		private static readonly InputFeatureUsage<Vector2>[] k_Vec2UsageList;

		public InputAxes inputBinding
		{
			get
			{
				return default(InputAxes);
			}
			set
			{
			}
		}

		public List<XRBaseController> controllers
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float deadzoneMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float deadzoneMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override Vector2 ReadInput()
		{
			return default(Vector2);
		}

		protected Vector2 GetDeadzoneAdjustedValue(Vector2 value)
		{
			return default(Vector2);
		}

		protected float GetDeadzoneAdjustedValue(float value)
		{
			return 0f;
		}
	}
}
