using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Average")]
	public sealed class Vector3Average : Average<Vector3>
	{
		public override Vector3 Operation(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public override Vector3 Operation(IEnumerable<Vector3> values)
		{
			return default(Vector3);
		}

		public Vector3Average()
		{
			((Average<>)(object)this)._002Ector();
		}
	}
}
