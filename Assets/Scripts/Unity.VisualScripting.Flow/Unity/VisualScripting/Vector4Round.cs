using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Round")]
	public sealed class Vector4Round : Round<Vector4, Vector4>
	{
		protected override Vector4 Floor(Vector4 input)
		{
			return default(Vector4);
		}

		protected override Vector4 AwayFromZero(Vector4 input)
		{
			return default(Vector4);
		}

		protected override Vector4 Ceiling(Vector4 input)
		{
			return default(Vector4);
		}

		public Vector4Round()
		{
			((Round<, >)(object)this)._002Ector();
		}
	}
}
