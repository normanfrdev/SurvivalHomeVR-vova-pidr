using System;
using UnityEngine;

namespace TMPro
{
	[RequireComponent(typeof(MeshRenderer))]
	[ExecuteAlways]
	public class TMP_SubMesh : MonoBehaviour
	{
		[SerializeField]
		private TMP_FontAsset m_fontAsset;

		[SerializeField]
		private TMP_SpriteAsset m_spriteAsset;

		[SerializeField]
		private Material m_material;

		[SerializeField]
		private Material m_sharedMaterial;

		private Material m_fallbackMaterial;

		private Material m_fallbackSourceMaterial;

		[SerializeField]
		private bool m_isDefaultMaterial;

		[SerializeField]
		private float m_padding;

		[SerializeField]
		private Renderer m_renderer;

		private MeshFilter m_meshFilter;

		private Mesh m_mesh;

		[SerializeField]
		private TextMeshPro m_TextComponent;

		[NonSerialized]
		private bool m_isRegisteredForEvents;

		public TMP_FontAsset fontAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_SpriteAsset spriteAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material sharedMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material fallbackMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material fallbackSourceMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isDefaultMaterial
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float padding
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Renderer renderer => null;

		public MeshFilter meshFilter => null;

		public Mesh mesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_Text textComponent => null;

		public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference)
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		public void DestroySelf()
		{
		}

		private Material GetMaterial(Material mat)
		{
			return null;
		}

		private Material CreateMaterialInstance(Material source)
		{
			return null;
		}

		private Material GetSharedMaterial()
		{
			return null;
		}

		private void SetSharedMaterial(Material mat)
		{
		}

		public float GetPaddingForMaterial()
		{
			return 0f;
		}

		public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold)
		{
		}

		public void SetVerticesDirty()
		{
		}

		public void SetMaterialDirty()
		{
		}

		protected void UpdateMaterial()
		{
		}
	}
}
