using System.Runtime.InteropServices;
using UnityEngine;

namespace PXR_Audio.Spatializer
{
	public struct MeshConfig
	{
		[MarshalAs(UnmanagedType.U1)]
		public bool enabled;

		[MarshalAs(UnmanagedType.U4)]
		public AcousticsMaterial materialType;

		public NativeVector4f absorption;

		public float scattering;

		public float transmission;

		public NativeMatrix4x4f toWorldTransform;

		public MeshConfig(bool enabled, PXR_Audio_Spatializer_SceneMaterial material, Matrix4x4 toWorldMatrix4X4)
		{
		}

		public void SetMaterial(PXR_Audio_Spatializer_SceneMaterial material)
		{
		}

		public void SetTransformMatrix4x4(Matrix4x4 toWorldMatrix4X4)
		{
		}
	}
}
