using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Angle")]
	public sealed class Vector2Angle : Angle<Vector2>
	{
		public override float Operation(Vector2 a, Vector2 b)
		{
			return 0f;
		}

		public Vector2Angle()
		{
			((Angle<>)(object)this)._002Ector();
		}
	}
}
