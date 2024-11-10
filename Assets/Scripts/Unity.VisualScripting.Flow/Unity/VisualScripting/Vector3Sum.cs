using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Add")]
	public sealed class Vector3Sum : Sum<Vector3>, IDefaultValue<Vector3>
	{
		[DoNotSerialize]
		public Vector3 defaultValue => default(Vector3);

		public override Vector3 Operation(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public override Vector3 Operation(IEnumerable<Vector3> values)
		{
			return default(Vector3);
		}

		public Vector3Sum()
		{
			((Sum<>)(object)this)._002Ector();
		}
	}
}
