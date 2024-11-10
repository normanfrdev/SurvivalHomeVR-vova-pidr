using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Per Second")]
	public sealed class Vector4PerSecond : PerSecond<Vector4>
	{
		public override Vector4 Operation(Vector4 input)
		{
			return default(Vector4);
		}

		public Vector4PerSecond()
		{
			((PerSecond<>)(object)this)._002Ector();
		}
	}
}
