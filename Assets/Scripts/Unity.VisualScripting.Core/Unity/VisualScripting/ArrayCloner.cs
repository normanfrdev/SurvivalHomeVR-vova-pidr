using System;

namespace Unity.VisualScripting
{
	public sealed class ArrayCloner : Cloner<Array>
	{
		public override bool Handles(Type type)
		{
			return false;
		}

		public override Array ConstructClone(Type type, Array original)
		{
			return null;
		}

		public override void FillClone(Type type, ref Array clone, Array original, CloningContext context)
		{
		}

		public ArrayCloner()
		{
			((Cloner<>)(object)this)._002Ector();
		}
	}
}
