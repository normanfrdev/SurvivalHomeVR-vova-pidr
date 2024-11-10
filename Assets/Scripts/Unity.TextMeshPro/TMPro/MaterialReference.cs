using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	public struct MaterialReference
	{
		public int index;

		public TMP_FontAsset fontAsset;

		public TMP_SpriteAsset spriteAsset;

		public Material material;

		public bool isDefaultMaterial;

		public bool isFallbackMaterial;

		public Material fallbackMaterial;

		public float padding;

		public int referenceCount;

		public MaterialReference(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding)
		{
		}

		public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset)
		{
			return false;
		}

		public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return 0;
		}

		public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
		{
			return 0;
		}
	}
}
