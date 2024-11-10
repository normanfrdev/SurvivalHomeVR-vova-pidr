using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public struct VertexGradient
	{
		public Color topLeft;

		public Color topRight;

		public Color bottomLeft;

		public Color bottomRight;

		public VertexGradient(Color color)
		{
		}

		public VertexGradient(Color color0, Color color1, Color color2, Color color3)
		{
		}
	}
}
