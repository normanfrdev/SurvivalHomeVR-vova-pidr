using UnityEngine;

namespace Unity.VRTemplate
{
	public class BezierCurve : MonoBehaviour
	{
		public enum UpdateType
		{
			UpdateAndBeforeRender = 0,
			Update = 1,
			BeforeRender = 2
		}

		private const float k_ViewerScaleChangeThreshold = 0.1f;

		[SerializeField]
		[Tooltip("The time within the frame that the curve will be updated. If this Bezier Curve is attached to a transform that is updating before render, then enabling updates in Before Render will keep the line connected without delay.")]
		private UpdateType m_UpdateTrackingType;

		[SerializeField]
		[Tooltip("The transform that determines the position, handle rotation, and handle scale of the start point of the bezier curve.")]
		private Transform m_StartPoint;

		[SerializeField]
		[Tooltip("The transform that determines the position, handle rotation, and handle scale of the end point of the bezier curve.")]
		private Transform m_EndPoint;

		[SerializeField]
		[Tooltip("Controls the scale factor of the curve's start bezier handle.")]
		private float m_CurveFactorStart;

		[SerializeField]
		[Tooltip("Controls the scale factor of the curve's end bezier handle.")]
		private float m_CurveFactorEnd;

		[SerializeField]
		[Tooltip("Controls the number of segments used to draw the curve.")]
		private int m_SegmentCount;

		[SerializeField]
		[Tooltip("When enabled, the line color gradient will be animated so that an opaque part travels along the line.")]
		private bool m_Animate;

		[SerializeField]
		[Tooltip("If animated, this controls the speed that the animation of the line.")]
		private float m_AnimSpeed;

		[SerializeField]
		[Tooltip("If animated, this color will be the main opaque color of the gradient")]
		private Color m_GradientKeyColor;

		[SerializeField]
		[Tooltip("The line renderer that will draw the curve. If not set it will find a line renderer on this GameObject.")]
		private LineRenderer m_LineRenderer;

		private Vector3[] m_ControlPoints;

		private float m_Time;

		private float m_LineWidth;

		private float m_LastViewerScale;

		private Vector3 m_LastStartPosition;

		private Vector3 m_LastEndPosition;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnBeforeRender()
		{
		}

		private void Update()
		{
		}

		[ContextMenu("Draw")]
		public void DrawCurve()
		{
		}

		private static Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Vector3);
		}

		private void AnimateCurve()
		{
		}
	}
}
