using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Subtract")]
	public sealed class Vector3Subtract : Subtract<Vector3>
	{
		protected override Vector3 defaultMinuend => default(Vector3);

		protected override Vector3 defaultSubtrahend => default(Vector3);

		public override Vector3 Operation(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public Vector3Subtract()
		{
			((Subtract<>)(object)this)._002Ector();
		}
	}
}
