using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Divide")]
	public sealed class Vector3Divide : Divide<Vector3>
	{
		protected override Vector3 defaultDividend => default(Vector3);

		protected override Vector3 defaultDivisor => default(Vector3);

		public override Vector3 Operation(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public Vector3Divide()
		{
			((Divide<>)(object)this)._002Ector();
		}
	}
}
