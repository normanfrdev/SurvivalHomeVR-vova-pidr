using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Project")]
	public sealed class Vector3Project : Project<Vector3>
	{
		public override Vector3 Operation(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public Vector3Project()
		{
			((Project<>)(object)this)._002Ector();
		}
	}
}
