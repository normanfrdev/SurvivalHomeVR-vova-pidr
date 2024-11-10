namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.Hands
{
	internal class HandExpressionCapture : ScriptableObject
	{
		[SerializeField]
		[Tooltip("An icon to represent the hand expression.")]
		private Sprite m_Icon;

		[SerializeField]
		[Tooltip("The captured left hand joint poses.")]
		private Pose[] m_LeftCapturedPoses;

		[SerializeField]
		[Tooltip("The captured right hand joint poses.")]
		private Pose[] m_RightCapturedPoses;

		public Sprite icon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Pose[] leftHandCapturedPoses
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Pose[] rightHandCapturedPoses
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
