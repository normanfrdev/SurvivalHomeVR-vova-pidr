using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Unity.XR.PXR
{
	public class PXR_ObjImporter : MonoBehaviour
	{
		private static PXR_ObjImporter instance;

		private List<int> triangles;

		private List<Vector3> vertices;

		private List<Vector2> uv;

		private List<Vector3> normals;

		private List<PxrVector3Int> faceData;

		private List<int> intArray;

		private const int MinPow10 = -16;

		private const int MaxPow10 = 16;

		private const int NumPows10 = 33;

		private static readonly float[] pow10;

		public static PXR_ObjImporter Instance => null;

		public Mesh ImportFile(string filePath)
		{
			return null;
		}

		private void LoadMeshData(string fileName)
		{
		}

		private float GetFloat(StringBuilder sb, ref int start, ref StringBuilder sbFloat)
		{
			return 0f;
		}

		private int GetInt(StringBuilder sb, ref int start, ref StringBuilder sbInt)
		{
			return 0;
		}

		private static float[] GenerateLookupTable()
		{
			return null;
		}

		private float ParseFloat(StringBuilder value)
		{
			return 0f;
		}

		private int IntParseFast(StringBuilder value)
		{
			return 0;
		}
	}
}
