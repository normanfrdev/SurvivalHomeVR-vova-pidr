using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;

namespace Unity.VisualScripting
{
	public sealed class FakeSerializationCloner : ReflectedCloner
	{
		public fsConfig config
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override void BeforeClone(Type type, object original)
		{
		}

		public override void AfterClone(Type type, object clone)
		{
		}

		protected override IEnumerable<MemberInfo> GetMembers(Type type)
		{
			return null;
		}
	}
}
