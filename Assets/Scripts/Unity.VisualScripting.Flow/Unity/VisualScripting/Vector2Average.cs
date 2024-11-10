using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Average")]
	public sealed class Vector2Average : Average<Vector2>
	{
		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public override Vector2 Operation(IEnumerable<Vector2> values)
		{
			return default(Vector2);
		}

		public Vector2Average()
		{
			((Average<>)(object)this)._002Ector();
		}
	}
}
