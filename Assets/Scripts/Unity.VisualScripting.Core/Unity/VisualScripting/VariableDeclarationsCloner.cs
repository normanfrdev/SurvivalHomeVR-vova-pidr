using System;

namespace Unity.VisualScripting
{
	public sealed class VariableDeclarationsCloner : Cloner<VariableDeclarations>
	{
		public static readonly VariableDeclarationsCloner instance;

		public override bool Handles(Type type)
		{
			return false;
		}

		public override VariableDeclarations ConstructClone(Type type, VariableDeclarations original)
		{
			return null;
		}

		public override void FillClone(Type type, ref VariableDeclarations clone, VariableDeclarations original, CloningContext context)
		{
		}

		public VariableDeclarationsCloner()
		{
			((Cloner<>)(object)this)._002Ector();
		}
	}
}
