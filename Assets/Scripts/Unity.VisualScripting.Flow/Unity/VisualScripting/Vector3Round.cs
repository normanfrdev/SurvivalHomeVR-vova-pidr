using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Round")]
	public sealed class Vector3Round : Round<Vector3, Vector3>
	{
		protected override Vector3 Floor(Vector3 input)
		{
			return default(Vector3);
		}

		protected override Vector3 AwayFromZero(Vector3 input)
		{
			return default(Vector3);
		}

		protected override Vector3 Ceiling(Vector3 input)
		{
			return default(Vector3);
		}

		public Vector3Round()
		{
			((Round<, >)(object)this)._002Ector();
		}
	}
}
