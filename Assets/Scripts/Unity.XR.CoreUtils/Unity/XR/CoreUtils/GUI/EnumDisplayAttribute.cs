using UnityEngine;

namespace Unity.XR.CoreUtils.GUI
{
	public sealed class EnumDisplayAttribute : PropertyAttribute
	{
		public string[] Names;

		public int[] Values;

		public EnumDisplayAttribute(params object[] enumValues)
		{
		}
	}
}
