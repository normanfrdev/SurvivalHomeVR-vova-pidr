using System;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals
{
	[Serializable]
	public class LineProperties
	{
		private const float k_DefaultLineWidth = 0.005f;

		[Header("Bend Settings")]
		[SerializeField]
		[Tooltip("Determine if the line should smoothly curve when this state property is active. If false, a straight line will be drawn.")]
		private bool m_SmoothlyCurveLine;

		[SerializeField]
		[Range(0f, 1f)]
		[Tooltip("Ratio to control the bend of the line by adjusting the mid-point. A value of 1 defaults to a straight line.")]
		private float m_LineBendRatio;

		[Header("Width Settings")]
		[SerializeField]
		[Tooltip("Determine if the line width should be customized from defaults when this state property is active.")]
		private bool m_AdjustWidth;

		[SerializeField]
		[Tooltip("Width of the line at the start.")]
		private float m_StarWidth;

		[SerializeField]
		[Tooltip("Width of the line at the end.")]
		private float m_EndWidth;

		[SerializeField]
		[Range(0f, 10f)]
		[Tooltip("If greater than 0, the curve end width will be scaled based on the the percentage of the line length to the max visual curve distance, multiplied by the scale factor.")]
		private float m_EndWidthScaleDistanceFactor;

		[Header("Gradient Settings")]
		[SerializeField]
		[Tooltip("Determine if the line color should change when this state property is active.")]
		private bool m_AdjustGradient;

		[SerializeField]
		[Tooltip("Color gradient to use when this state property is active.")]
		private Gradient m_Gradient;

		[Header("Expand Settings")]
		[SerializeField]
		[Tooltip("Determine if the line mode expansion should be customized from defaults")]
		private bool m_CustomizeExpandLineDrawPercent;

		[SerializeField]
		[Tooltip("Percent of the line to draw when using the expand from hit point mode when this state property is active.")]
		private float m_ExpandModeLineDrawPercent;

		public bool smoothlyCurveLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float lineBendRatio
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool adjustWidth
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float starWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float endWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float endWidthScaleDistanceFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool adjustGradient
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Gradient gradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool customizeExpandLineDrawPercent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float expandModeLineDrawPercent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
