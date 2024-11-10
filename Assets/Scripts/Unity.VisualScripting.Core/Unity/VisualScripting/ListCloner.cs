using System;
using System.Collections;

namespace Unity.VisualScripting
{
	public sealed class ListCloner : Cloner<IList>
	{
		public override bool Handles(Type type)
		{
			return false;
		}

		public override void FillClone(Type type, ref IList clone, IList original, CloningContext context)
		{
		}

		public ListCloner()
		{
			((Cloner<>)(object)this)._002Ector();
		}
	}
}
