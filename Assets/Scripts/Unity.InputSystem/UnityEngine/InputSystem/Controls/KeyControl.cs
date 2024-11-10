using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Controls
{
	public class KeyControl : ButtonControl
	{
		private int m_ScanCode;

		public Key keyCode
		{
			[CompilerGenerated]
			get
			{
				return default(Key);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int scanCode => 0;

		protected override void RefreshConfiguration()
		{
		}
	}
}
