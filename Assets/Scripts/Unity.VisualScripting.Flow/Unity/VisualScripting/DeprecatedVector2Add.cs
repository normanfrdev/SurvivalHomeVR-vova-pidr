using System;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 2")]
	[UnitTitle("Add")]
	[Obsolete("Use the new \"Add (Math/Vector 2)\" node instead.")]
	[RenamedFrom("Bolt.Vector2Add")]
	[RenamedFrom("Unity.VisualScripting.Vector2Add")]
	public sealed class DeprecatedVector2Add : Add<Vector2>
	{
		protected override Vector2 defaultB => default(Vector2);

		public override Vector2 Operation(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		public DeprecatedVector2Add()
		{
			((Add<>)(object)this)._002Ector();
		}
	}
}
