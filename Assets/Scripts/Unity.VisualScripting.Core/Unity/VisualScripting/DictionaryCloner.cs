using System;
using System.Collections;

namespace Unity.VisualScripting
{
	public sealed class DictionaryCloner : Cloner<IDictionary>
	{
		public override bool Handles(Type type)
		{
			return false;
		}

		public override void FillClone(Type type, ref IDictionary clone, IDictionary original, CloningContext context)
		{
		}

		public DictionaryCloner()
		{
			((Cloner<>)(object)this)._002Ector();
		}
	}
}
