using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Rendering
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public abstract class MaterialHelperBase : MonoBehaviour
	{
		[SerializeField]
		private Renderer m_Renderer;

		[SerializeField]
		private int m_MaterialIndex;

		public Renderer rendererTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int materialIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected bool isInitialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected void OnEnable()
		{
		}

		protected virtual void Initialize()
		{
		}

		public Material GetSharedMaterialForTarget()
		{
			return null;
		}
	}
}
