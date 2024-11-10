using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Lerp")]
	public sealed class Vector4Lerp : Lerp<Vector4>
	{
		protected override Vector4 defaultA => default(Vector4);

		protected override Vector4 defaultB => default(Vector4);

		public override Vector4 Operation(Vector4 a, Vector4 b, float t)
		{
			return default(Vector4);
		}

		public Vector4Lerp()
		{
			((Lerp<>)(object)this)._002Ector();
		}
	}
}
