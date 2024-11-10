using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Move Towards")]
	public sealed class Vector2MoveTowards : MoveTowards<Vector2>
	{
		protected override Vector2 defaultCurrent => default(Vector2);

		protected override Vector2 defaultTarget => default(Vector2);

		public override Vector2 Operation(Vector2 current, Vector2 target, float maxDelta)
		{
			return default(Vector2);
		}

		public Vector2MoveTowards()
		{
			((MoveTowards<>)(object)this)._002Ector();
		}
	}
}
