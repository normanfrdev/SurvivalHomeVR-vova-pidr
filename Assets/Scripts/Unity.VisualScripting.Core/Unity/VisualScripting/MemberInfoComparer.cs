using System.Collections.Generic;
using System.Reflection;

namespace Unity.VisualScripting
{
	public class MemberInfoComparer : EqualityComparer<MemberInfo>
	{
		public override bool Equals(MemberInfo x, MemberInfo y)
		{
			return false;
		}

		public override int GetHashCode(MemberInfo obj)
		{
			return 0;
		}

		public MemberInfoComparer()
		{
			((EqualityComparer<T>)(object)this)._002Ector();
		}
	}
}
