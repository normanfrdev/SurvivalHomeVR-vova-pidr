using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Move Towards")]
	public sealed class Vector3MoveTowards : MoveTowards<Vector3>
	{
		protected override Vector3 defaultCurrent => default(Vector3);

		protected override Vector3 defaultTarget => default(Vector3);

		public override Vector3 Operation(Vector3 current, Vector3 target, float maxDelta)
		{
			return default(Vector3);
		}

		public Vector3MoveTowards()
		{
			((MoveTowards<>)(object)this)._002Ector();
		}
	}
}
