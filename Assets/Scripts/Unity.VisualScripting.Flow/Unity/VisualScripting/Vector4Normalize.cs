using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Normalize")]
	public sealed class Vector4Normalize : Normalize<Vector4>
	{
		public override Vector4 Operation(Vector4 input)
		{
			return default(Vector4);
		}

		public Vector4Normalize()
		{
			((Normalize<>)(object)this)._002Ector();
		}
	}
}
