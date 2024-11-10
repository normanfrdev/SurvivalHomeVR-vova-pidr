using System;
using UnityEngine;

namespace Unity.VisualScripting
{
	internal sealed class GradientCloner : Cloner<Gradient>
	{
		public override bool Handles(Type type)
		{
			return false;
		}

		public override Gradient ConstructClone(Type type, Gradient original)
		{
			return null;
		}

		public override void FillClone(Type type, ref Gradient clone, Gradient original, CloningContext context)
		{
		}

		public GradientCloner()
		{
			((Cloner<>)(object)this)._002Ector();
		}
	}
}
