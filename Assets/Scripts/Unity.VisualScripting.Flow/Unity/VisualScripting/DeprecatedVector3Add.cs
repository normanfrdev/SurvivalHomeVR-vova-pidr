using System;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Math/Vector 3")]
	[UnitTitle("Add")]
	[Obsolete("Use the new \"Add (Math/Vector 3)\" instead.")]
	[RenamedFrom("Bolt.Vector3Add")]
	[RenamedFrom("Unity.VisualScripting.Vector3Add")]
	public sealed class DeprecatedVector3Add : Add<Vector3>
	{
		protected override Vector3 defaultB => default(Vector3);

		public override Vector3 Operation(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public DeprecatedVector3Add()
		{
			((Add<>)(object)this)._002Ector();
		}
	}
}
