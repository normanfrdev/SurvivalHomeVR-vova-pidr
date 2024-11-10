using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Subtract")]
	public sealed class Vector4Subtract : Subtract<Vector4>
	{
		protected override Vector4 defaultMinuend => default(Vector4);

		protected override Vector4 defaultSubtrahend => default(Vector4);

		public override Vector4 Operation(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		public Vector4Subtract()
		{
			((Subtract<>)(object)this)._002Ector();
		}
	}
}
