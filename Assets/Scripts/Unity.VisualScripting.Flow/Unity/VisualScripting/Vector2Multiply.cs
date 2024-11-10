using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Multiply")]
	public sealed class Vector2Multiply : Multiply<Vector2>
	{
		protected override Vector2 defaultB => default(Vector2);

		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public Vector2Multiply()
		{
			((Multiply<>)(object)this)._002Ector();
		}
	}
}
