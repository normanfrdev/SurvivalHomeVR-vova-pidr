using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Absolute")]
	public sealed class Vector3Absolute : Absolute<Vector3>
	{
		protected override Vector3 Operation(Vector3 input)
		{
			return default(Vector3);
		}

		public Vector3Absolute()
		{
			((Absolute<>)(object)this)._002Ector();
		}
	}
}
