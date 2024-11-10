using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Divide")]
	public sealed class Vector4Divide : Divide<Vector4>
	{
		protected override Vector4 defaultDividend => default(Vector4);

		protected override Vector4 defaultDivisor => default(Vector4);

		public override Vector4 Operation(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		public Vector4Divide()
		{
			((Divide<>)(object)this)._002Ector();
		}
	}
}
