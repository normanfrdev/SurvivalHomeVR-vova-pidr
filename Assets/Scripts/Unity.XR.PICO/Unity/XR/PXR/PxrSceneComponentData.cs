using System;
using UnityEngine;

namespace Unity.XR.PXR
{
	public struct PxrSceneComponentData
	{
		public Guid uuid;

		public Vector3 position;

		public Quaternion rotation;

		public PxrSemanticLabel label;

		public PxrSceneComponentType[] types;

		public PxrSceneBox3D box3D;

		public PxrSceneBox2D box2D;

		public PxrScenePolygon polygon;
	}
}
