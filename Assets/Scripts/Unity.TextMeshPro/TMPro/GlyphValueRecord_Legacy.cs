using System;
using UnityEngine.TextCore.LowLevel;

namespace TMPro
{
	[Serializable]
	public struct GlyphValueRecord_Legacy
	{
		public float xPlacement;

		public float yPlacement;

		public float xAdvance;

		public float yAdvance;

		internal GlyphValueRecord_Legacy(GlyphValueRecord valueRecord)
		{
		}

		public static GlyphValueRecord_Legacy operator +(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b)
		{
			return default(GlyphValueRecord_Legacy);
		}
	}
}
