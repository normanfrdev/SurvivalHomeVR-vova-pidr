using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Subtract")]
	public sealed class Vector2Subtract : Subtract<Vector2>
	{
		protected override Vector2 defaultMinuend => default(Vector2);

		protected override Vector2 defaultSubtrahend => default(Vector2);

		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public Vector2Subtract()
		{
			((Subtract<>)(object)this)._002Ector();
		}
	}
}
