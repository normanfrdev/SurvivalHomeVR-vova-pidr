using System;

namespace Unity.VisualScripting.FullSerializer
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class fsObjectAttribute : Attribute
	{
		public Type[] PreviousModels;

		public string VersionString;

		public fsMemberSerialization MemberSerialization;

		public Type Converter;

		public Type Processor;

		public fsObjectAttribute()
		{
		}

		public fsObjectAttribute(string versionString, params Type[] previousModels)
		{
		}
	}
}
