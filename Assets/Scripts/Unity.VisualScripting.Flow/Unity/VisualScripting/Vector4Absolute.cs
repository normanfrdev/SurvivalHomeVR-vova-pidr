using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Absolute")]
	public sealed class Vector4Absolute : Absolute<Vector4>
	{
		protected override Vector4 Operation(Vector4 input)
		{
			return default(Vector4);
		}

		public Vector4Absolute()
		{
			((Absolute<>)(object)this)._002Ector();
		}
	}
}
