using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Minimum")]
	public sealed class Vector2Minimum : Minimum<Vector2>
	{
		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public override Vector2 Operation(IEnumerable<Vector2> values)
		{
			return default(Vector2);
		}

		public Vector2Minimum()
		{
			((Minimum<>)(object)this)._002Ector();
		}
	}
}
