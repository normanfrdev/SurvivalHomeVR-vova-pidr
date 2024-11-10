using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Angle")]
	public sealed class Vector3Angle : Angle<Vector3>
	{
		public override float Operation(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		public Vector3Angle()
		{
			((Angle<>)(object)this)._002Ector();
		}
	}
}
