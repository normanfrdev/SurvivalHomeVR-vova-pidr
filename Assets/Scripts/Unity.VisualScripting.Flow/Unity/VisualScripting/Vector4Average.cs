using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Average")]
	public sealed class Vector4Average : Average<Vector4>
	{
		public override Vector4 Operation(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		public override Vector4 Operation(IEnumerable<Vector4> values)
		{
			return default(Vector4);
		}

		public Vector4Average()
		{
			((Average<>)(object)this)._002Ector();
		}
	}
}
