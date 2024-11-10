using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Modulo")]
	public sealed class Vector2Modulo : Modulo<Vector2>
	{
		protected override Vector2 defaultDividend => default(Vector2);

		protected override Vector2 defaultDivisor => default(Vector2);

		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public Vector2Modulo()
		{
			((Modulo<>)(object)this)._002Ector();
		}
	}
}
