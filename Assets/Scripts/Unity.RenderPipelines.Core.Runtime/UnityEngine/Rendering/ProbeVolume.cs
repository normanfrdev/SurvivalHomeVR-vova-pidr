using System;

namespace UnityEngine.Rendering
{
	[ExecuteAlways]
	[AddComponentMenu("Rendering/Probe Volume")]
	public class ProbeVolume : MonoBehaviour
	{
		public enum Mode
		{
			Global = 0,
			Scene = 1,
			Local = 2
		}

		private enum Version
		{
			Initial = 0,
			LocalMode = 1,
			Count = 2
		}

		[Tooltip("When set to Global this Probe Volume considers all renderers with Contribute Global Illumination enabled. Local only considers renderers in the scene.\nThis list updates every time the Scene is saved or the lighting is baked.")]
		public Mode mode;

		public Vector3 size;

		[HideInInspector]
		[Min(0f)]
		public bool overrideRendererFilters;

		[HideInInspector]
		[Min(0f)]
		public float minRendererVolumeSize;

		public LayerMask objectLayerMask;

		[HideInInspector]
		public int lowestSubdivLevelOverride;

		[HideInInspector]
		public int highestSubdivLevelOverride;

		[HideInInspector]
		public bool overridesSubdivLevels;

		[SerializeField]
		internal bool mightNeedRebaking;

		[SerializeField]
		internal Matrix4x4 cachedTransform;

		[SerializeField]
		internal int cachedHashCode;

		[HideInInspector]
		[Tooltip("Whether spaces with no renderers need to be filled with bricks at lowest subdivision level.")]
		public bool fillEmptySpaces;

		[SerializeField]
		private Version version;

		[SerializeField]
		[Obsolete("Use mode instead")]
		public bool globalVolume;

		private void Awake()
		{
		}
	}
}
