namespace TMPro
{
	public struct GlyphPairKey
	{
		public uint firstGlyphIndex;

		public uint secondGlyphIndex;

		public uint key;

		public GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex)
		{
		}

		internal GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
		{
		}
	}
}
