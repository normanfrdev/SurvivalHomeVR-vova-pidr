using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Multiply")]
	public sealed class Vector4Multiply : Multiply<Vector4>
	{
		protected override Vector4 defaultB => default(Vector4);

		public override Vector4 Operation(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		public Vector4Multiply()
		{
			((Multiply<>)(object)this)._002Ector();
		}
	}
}
