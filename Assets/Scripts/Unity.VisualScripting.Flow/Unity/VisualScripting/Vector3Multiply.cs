using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Multiply")]
	public sealed class Vector3Multiply : Multiply<Vector3>
	{
		protected override Vector3 defaultB => default(Vector3);

		public override Vector3 Operation(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public Vector3Multiply()
		{
			((Multiply<>)(object)this)._002Ector();
		}
	}
}
