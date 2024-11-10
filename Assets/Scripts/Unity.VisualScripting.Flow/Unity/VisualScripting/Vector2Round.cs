using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Round")]
	public sealed class Vector2Round : Round<Vector2, Vector2>
	{
		protected override Vector2 Floor(Vector2 input)
		{
			return default(Vector2);
		}

		protected override Vector2 AwayFromZero(Vector2 input)
		{
			return default(Vector2);
		}

		protected override Vector2 Ceiling(Vector2 input)
		{
			return default(Vector2);
		}

		public Vector2Round()
		{
			((Round<, >)(object)this)._002Ector();
		}
	}
}
