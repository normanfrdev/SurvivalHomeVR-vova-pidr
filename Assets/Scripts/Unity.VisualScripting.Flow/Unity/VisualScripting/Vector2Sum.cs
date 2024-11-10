using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Add")]
	public sealed class Vector2Sum : Sum<Vector2>, IDefaultValue<Vector2>
	{
		[DoNotSerialize]
		public Vector2 defaultValue => default(Vector2);

		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public override Vector2 Operation(IEnumerable<Vector2> values)
		{
			return default(Vector2);
		}

		public Vector2Sum()
		{
			((Sum<>)(object)this)._002Ector();
		}
	}
}
