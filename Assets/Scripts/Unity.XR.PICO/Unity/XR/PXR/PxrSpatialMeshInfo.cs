using System;
using UnityEngine;
using UnityEngine.XR;

namespace Unity.XR.PXR
{
	public struct PxrSpatialMeshInfo
	{
		public Guid uuid;

		public MeshChangeState state;

		public Vector3 position;

		public Quaternion rotation;

		public ushort[] indices;

		public Vector3[] vertices;

		public PxrSemanticLabel[] labels;
	}
}
