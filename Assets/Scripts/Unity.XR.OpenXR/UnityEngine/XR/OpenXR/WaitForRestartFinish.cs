namespace UnityEngine.XR.OpenXR
{
	internal sealed class WaitForRestartFinish : CustomYieldInstruction
	{
		private float m_Timeout;

		public override bool keepWaiting => false;

		public WaitForRestartFinish(float timeout = 5f)
		{
		}
	}
}
