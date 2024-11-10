using System.Runtime.CompilerServices;

namespace UnityEngine.Timeline
{
	internal class TimeFieldAttribute : PropertyAttribute
	{
		public enum UseEditMode
		{
			None = 0,
			ApplyEditMode = 1
		}

		public UseEditMode useEditMode
		{
			[CompilerGenerated]
			get
			{
				return default(UseEditMode);
			}
		}

		public TimeFieldAttribute(UseEditMode useEditMode = UseEditMode.ApplyEditMode)
		{
		}
	}
}
