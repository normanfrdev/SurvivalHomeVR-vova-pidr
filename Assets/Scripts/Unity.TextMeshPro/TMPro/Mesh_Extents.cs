using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public struct Mesh_Extents
	{
		public Vector2 min;

		public Vector2 max;

		public Mesh_Extents(Vector2 min, Vector2 max)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
