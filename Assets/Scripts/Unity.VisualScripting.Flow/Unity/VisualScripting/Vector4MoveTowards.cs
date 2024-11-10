using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 4")]
	[UnitTitle("Move Towards")]
	public sealed class Vector4MoveTowards : MoveTowards<Vector4>
	{
		protected override Vector4 defaultCurrent => default(Vector4);

		protected override Vector4 defaultTarget => default(Vector4);

		public override Vector4 Operation(Vector4 current, Vector4 target, float maxDelta)
		{
			return default(Vector4);
		}

		public Vector4MoveTowards()
		{
			((MoveTowards<>)(object)this)._002Ector();
		}
	}
}
