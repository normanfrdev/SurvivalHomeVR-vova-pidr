using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Absolute")]
	public sealed class Vector2Absolute : Absolute<Vector2>
	{
		protected override Vector2 Operation(Vector2 input)
		{
			return default(Vector2);
		}

		public Vector2Absolute()
		{
			((Absolute<>)(object)this)._002Ector();
		}
	}
}
