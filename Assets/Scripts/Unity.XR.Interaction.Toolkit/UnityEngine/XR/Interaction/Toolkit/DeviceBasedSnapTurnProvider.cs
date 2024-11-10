using System;
using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[AddComponentMenu("XR/Locomotion/Legacy/Snap Turn Provider (Device-based)", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.DeviceBasedSnapTurnProvider.html")]
	[Obsolete("DeviceBasedSnapTurnProvider has been deprecated in version 3.0.0. Use SnapTurnProvider instead.")]
	public class DeviceBasedSnapTurnProvider : SnapTurnProviderBase
	{
		public enum InputAxes
		{
			Primary2DAxis = 0,
			Secondary2DAxis = 1
		}

		[SerializeField]
		[Tooltip("The 2D Input Axis on the controller devices that will be used to trigger a snap turn.")]
		private InputAxes m_TurnUsage;

		[SerializeField]
		[Tooltip("A list of controllers that allow Snap Turn.  If an XRController is not enabled, or does not have input actions enabled, snap turn will not work.")]
		private List<XRBaseController> m_Controllers;

		[SerializeField]
		[Tooltip("The deadzone that the controller movement will have to be above to trigger a snap turn.")]
		private float m_DeadZone;

		private static readonly InputFeatureUsage<Vector2>[] k_Vec2UsageList;

		public InputAxes turnUsage
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

		public float deadZone
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
	}
}
