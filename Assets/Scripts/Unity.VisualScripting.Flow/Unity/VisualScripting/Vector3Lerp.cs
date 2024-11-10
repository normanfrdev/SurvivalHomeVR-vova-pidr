using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Lerp")]
	public sealed class Vector3Lerp : Lerp<Vector3>
	{
		protected override Vector3 defaultA => default(Vector3);

		protected override Vector3 defaultB => default(Vector3);

		public override Vector3 Operation(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		public Vector3Lerp()
		{
			((Lerp<>)(object)this)._002Ector();
		}
	}
}
