using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Maximum")]
	public sealed class Vector2Maximum : Maximum<Vector2>
	{
		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public override Vector2 Operation(IEnumerable<Vector2> values)
		{
			return default(Vector2);
		}

		public Vector2Maximum()
		{
			((Maximum<>)(object)this)._002Ector();
		}
	}
}
