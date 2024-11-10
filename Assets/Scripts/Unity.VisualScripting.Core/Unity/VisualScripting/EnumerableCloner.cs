using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public sealed class EnumerableCloner : Cloner<IEnumerable>
	{
		private readonly Dictionary<Type, IOptimizedInvoker> addMethods;

		public override bool Handles(Type type)
		{
			return false;
		}

		public override void FillClone(Type type, ref IEnumerable clone, IEnumerable original, CloningContext context)
		{
		}

		private IOptimizedInvoker GetAddMethod(Type type)
		{
			return null;
		}

		public EnumerableCloner()
		{
			((Cloner<>)(object)this)._002Ector();
		}
	}
}
