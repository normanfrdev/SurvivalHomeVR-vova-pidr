using System;

namespace Unity.VisualScripting
{
	public static class EditorTimeBinding
	{
		public static Func<int> frameBinding;

		public static Func<float> timeBinding;

		public static int frame => 0;

		public static float time => 0f;

		static EditorTimeBinding()
		{
		}
	}
}
