using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Per Second")]
	public sealed class Vector3PerSecond : PerSecond<Vector3>
	{
		public override Vector3 Operation(Vector3 input)
		{
			return default(Vector3);
		}

		public Vector3PerSecond()
		{
			((PerSecond<>)(object)this)._002Ector();
		}
	}
}
