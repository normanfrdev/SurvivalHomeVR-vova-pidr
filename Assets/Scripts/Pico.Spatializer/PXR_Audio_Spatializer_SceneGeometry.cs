using System.Collections.Generic;
using PXR_Audio.Spatializer;
using UnityEngine;

[RequireComponent(typeof(PXR_Audio_Spatializer_SceneMaterial))]
public class PXR_Audio_Spatializer_SceneGeometry : MonoBehaviour
{
	[Tooltip("Whether include meshes in children game objects as the shape of this acoustic geometry.")]
	[SerializeField]
	private bool includeChildren;

	[Tooltip("Whether visualize meshes in current scene that are included as the shape of this acoustic geometry.\n  - non-static meshes are visualized using white wire frames;\n  - static meshes are visualized using green wire frames.")]
	[SerializeField]
	private bool visualizeMeshInEditor;

	[Tooltip("Baked static mesh used as the shape of this acoustic geometry.")]
	[SerializeField]
	private Mesh bakedStaticMesh;

	private int geometryId;

	private int staticGeometryID;

	private PXR_Audio_Spatializer_SceneMaterial material;

	private MeshConfig meshConfig;

	private uint propertyMask;

	private int currentContextUuid;

	public bool isStaticMeshBaked => false;

	public int GeometryId => 0;

	public int StaticGeometryId => 0;

	public PXR_Audio_Spatializer_SceneMaterial Material => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void UpdateAbsorptionMultiband(float[] absorptions)
	{
	}

	public void UpdateScattering(float scattering)
	{
	}

	public void UpdateTransmission(float transmission)
	{
	}

	public void UpdateMaterialType(AcousticsMaterial materialType)
	{
	}

	private void GetAllMeshFilter(Transform transform, bool includeChildren, List<MeshFilter> meshFilterList, bool isStatic, LayerMask layerMask)
	{
	}

	private static Mesh CombineMeshes(List<MeshFilter> meshFilterList, Transform rootTransform)
	{
		return null;
	}

	private static float[] FlattenVerticesBuffer(Vector3[] verticesBuffer)
	{
		return null;
	}

	public Result SubmitMeshToContext()
	{
		return default(Result);
	}

	public Result SubmitStaticMeshToContext()
	{
		return default(Result);
	}

	public void OnDrawGizmos()
	{
	}
}
