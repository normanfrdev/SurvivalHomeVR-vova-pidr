using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Divide")]
	public sealed class Vector2Divide : Divide<Vector2>
	{
		protected override Vector2 defaultDividend => default(Vector2);

		protected override Vector2 defaultDivisor => default(Vector2);

		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public Vector2Divide()
		{
			((Divide<>)(object)this)._002Ector();
		}
	}
}
