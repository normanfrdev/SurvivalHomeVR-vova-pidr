using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Dot Product")]
	public sealed class Vector2DotProduct : DotProduct<Vector2>
	{
		public override float Operation(Vector2 a, Vector2 b)
		{
			return 0f;
		}

		public Vector2DotProduct()
		{
			((DotProduct<>)(object)this)._002Ector();
		}
	}
}
