using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Distance")]
	public sealed class Vector3Distance : Distance<Vector3>
	{
		public override float Operation(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public Vector3Distance()
		{
			((Distance<>)(object)this)._002Ector();
		}
	}
}
