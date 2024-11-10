using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
	public class ObjectSpawner : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The camera that objects will face when spawned. If not set, defaults to the main camera.")]
		private Camera m_CameraToFace;

		[SerializeField]
		[Tooltip("The list of prefabs available to spawn.")]
		private List<GameObject> m_ObjectPrefabs;

		[SerializeField]
		[Tooltip("Optional prefab to spawn for each spawned object. Use a prefab with the Destroy Self component to make sure the visualization only lives temporarily.")]
		private GameObject m_SpawnVisualizationPrefab;

		[SerializeField]
		[Tooltip("The index of the prefab to spawn. If outside the range of the list, this behavior will select a random object each time it spawns.")]
		private int m_SpawnOptionIndex;

		[SerializeField]
		[Tooltip("Whether to only spawn an object if the spawn point is within view of the camera.")]
		private bool m_OnlySpawnInView;

		[SerializeField]
		[Tooltip("The size, in viewport units, of the periphery inside the viewport that will not be considered in view.")]
		private float m_ViewportPeriphery;

		[SerializeField]
		[Tooltip("When enabled, the object will be rotated about the y-axis when spawned by Spawn Angle Range, in relation to the direction of the spawn point to the camera.")]
		private bool m_ApplyRandomAngleAtSpawn;

		[SerializeField]
		[Tooltip("The range in degrees that the object will randomly be rotated about the y axis when spawned, in relation to the direction of the spawn point to the camera.")]
		private float m_SpawnAngleRange;

		[SerializeField]
		[Tooltip("Whether to spawn each object as a child of this object.")]
		private bool m_SpawnAsChildren;

		public Camera cameraToFace
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<GameObject> objectPrefabs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject spawnVisualizationPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int spawnOptionIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isSpawnOptionRandomized => false;

		public bool onlySpawnInView
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float viewportPeriphery
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool applyRandomAngleAtSpawn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float spawnAngleRange
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool spawnAsChildren
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<GameObject> objectSpawned
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void EnsureFacingCamera()
		{
		}

		public void RandomizeSpawnOption()
		{
		}

		public bool TrySpawnObject(Vector3 spawnPoint, Vector3 spawnNormal)
		{
			return false;
		}
	}
}
