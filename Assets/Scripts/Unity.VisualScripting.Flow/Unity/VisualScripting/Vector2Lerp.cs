using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Lerp")]
	public sealed class Vector2Lerp : Lerp<Vector2>
	{
		protected override Vector2 defaultA => default(Vector2);

		protected override Vector2 defaultB => default(Vector2);

		public override Vector2 Operation(Vector2 a, Vector2 b, float t)
		{
			return default(Vector2);
		}

		public Vector2Lerp()
		{
			((Lerp<>)(object)this)._002Ector();
		}
	}
}
