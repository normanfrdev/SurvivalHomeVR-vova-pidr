using System;

namespace UnityEngine.Rendering
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
	public class PackingAttribute : Attribute
	{
		public string[] displayNames;

		public float[] range;

		public FieldPacking packingScheme;

		public int offsetInSource;

		public int sizeInBits;

		public bool isDirection;

		public bool sRGBDisplay;

		public bool checkIsNormalized;

		public string preprocessor;

		public PackingAttribute(string[] displayNames, FieldPacking packingScheme = FieldPacking.NoPacking, int bitSize = 32, int offsetInSource = 0, float minValue = 0f, float maxValue = 1f, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, string preprocessor = "")
		{
		}

		public PackingAttribute(string displayName = "", FieldPacking packingScheme = FieldPacking.NoPacking, int bitSize = 0, int offsetInSource = 0, float minValue = 0f, float maxValue = 1f, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, string preprocessor = "")
		{
		}
	}
}
