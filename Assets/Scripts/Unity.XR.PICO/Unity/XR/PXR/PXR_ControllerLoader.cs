using LitJson;
using UnityEngine;

namespace Unity.XR.PXR
{
	public class PXR_ControllerLoader : MonoBehaviour
	{
		private enum ControllerSimulationType
		{
			None = 0,
			Neo3 = 1,
			PICO4 = 2,
			G3 = 3,
			PICO4U = 4
		}

		[SerializeField]
		private PXR_Input.Controller hand;

		public GameObject neo3L;

		public GameObject neo3R;

		public GameObject PICO_4L;

		public GameObject PICO_4R;

		public GameObject G3;

		public GameObject PICO_4U_L;

		public GameObject PICO_4U_R;

		public Material legacyMaterial;

		private Texture2D modelTexture2D;

		private int controllerType;

		private JsonData curControllerData;

		private int systemOrLocal;

		private bool loadModelSuccess;

		private string modelName;

		private string texFormat;

		private string prePath;

		private string modelFilePath;

		private bool leftControllerState;

		private bool rightControllerState;

		public PXR_ControllerLoader(PXR_Input.Controller controller)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void RefreshController(PXR_Input.Controller hand)
		{
		}

		private void LoadResFromJson()
		{
		}

		private void DestroyLocalController()
		{
		}

		private void LoadControllerFromPrefab(PXR_Input.Controller hand)
		{
		}

		private void LoadControllerFromSystem(int id)
		{
		}

		private void LoadTexture(MeshRenderer mr, string controllerName, bool fromRes)
		{
		}

		private Texture2D LoadOneTexture(string filepath, bool fromRes)
		{
			return null;
		}

		private byte[] ReadPNG(string path)
		{
			return null;
		}
	}
}
