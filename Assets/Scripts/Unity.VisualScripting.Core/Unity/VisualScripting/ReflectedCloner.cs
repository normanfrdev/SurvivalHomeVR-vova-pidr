using System;
using System.Collections.Generic;
using System.Reflection;

namespace Unity.VisualScripting
{
	public abstract class ReflectedCloner : Cloner<object>
	{
		private readonly Dictionary<Type, MemberInfo[]> accessors;

		private readonly Dictionary<Type, IOptimizedAccessor[]> optimizedAccessors;

		public override bool Handles(Type type)
		{
			return false;
		}

		public override void FillClone(Type type, ref object clone, object original, CloningContext context)
		{
		}

		private MemberInfo[] GetAccessors(Type type)
		{
			return null;
		}

		private IOptimizedAccessor[] GetOptimizedAccessors(Type type)
		{
			return null;
		}

		protected virtual IEnumerable<MemberInfo> GetMembers(Type type)
		{
			return null;
		}

		protected virtual bool IncludeField(FieldInfo field)
		{
			return false;
		}

		protected virtual bool IncludeProperty(PropertyInfo property)
		{
			return false;
		}

		protected ReflectedCloner()
		{
			((Cloner<>)(object)this)._002Ector();
		}
	}
}
