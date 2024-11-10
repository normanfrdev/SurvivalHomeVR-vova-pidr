using System;
using System.Runtime.CompilerServices;

namespace Unity.XR.Oculus
{
	public class InputFocus
	{
		private static bool hadInputFocus;

		internal static bool hasInputFocus => false;

		public static event Action InputFocusAcquired
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action InputFocusLost
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static void Update()
		{
		}
	}
}
