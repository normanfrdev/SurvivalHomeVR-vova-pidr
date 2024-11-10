using System;

namespace Unity.XR.CoreUtils
{
	[AttributeUsage(AttributeTargets.Class)]
	public class ScriptableSettingsPathAttribute : Attribute
	{
		private readonly string m_Path;

		public string Path => null;

		public ScriptableSettingsPathAttribute(string path = "")
		{
		}
	}
}
