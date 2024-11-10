using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Minimum")]
	public sealed class Vector3Minimum : Minimum<Vector3>
	{
		public override Vector3 Operation(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public override Vector3 Operation(IEnumerable<Vector3> values)
		{
			return default(Vector3);
		}

		public Vector3Minimum()
		{
			((Minimum<>)(object)this)._002Ector();
		}
	}
}
