using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Add")]
	public sealed class Vector4Sum : Sum<Vector4>, IDefaultValue<Vector4>
	{
		[DoNotSerialize]
		public Vector4 defaultValue => default(Vector4);

		public override Vector4 Operation(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		public override Vector4 Operation(IEnumerable<Vector4> values)
		{
			return default(Vector4);
		}

		public Vector4Sum()
		{
			((Sum<>)(object)this)._002Ector();
		}
	}
}
