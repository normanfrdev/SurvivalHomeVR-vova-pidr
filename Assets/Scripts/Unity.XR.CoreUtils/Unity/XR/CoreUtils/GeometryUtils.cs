using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public static class GeometryUtils
	{
		private const float k_TwoPi = MathF.PI * 2f;

		private static readonly Vector3 k_Up;

		private static readonly Vector3 k_Forward;

		private static readonly Vector3 k_Zero;

		private static readonly Quaternion k_VerticalCorrection;

		private const float k_MostlyVertical = 0.95f;

		private static readonly List<Vector3> k_HullEdgeDirections;

		private static readonly HashSet<int> k_HullIndices;

		public static bool FindClosestEdge(List<Vector3> vertices, Vector3 point, out Vector3 vertexA, out Vector3 vertexB)
		{
			vertexA = default(Vector3);
			vertexB = default(Vector3);
			return false;
		}

		public static Vector3 PointOnOppositeSideOfPolygon(List<Vector3> vertices, Vector3 point)
		{
			return default(Vector3);
		}

		public static void TriangulatePolygon(List<int> indices, int vertCount, bool reverse = false)
		{
		}

		public static bool ClosestTimesOnTwoLines(Vector3 positionA, Vector3 velocityA, Vector3 positionB, Vector3 velocityB, out float s, out float t, double parallelTest = double.Epsilon)
		{
			s = default(float);
			t = default(float);
			return false;
		}

		public static bool ClosestTimesOnTwoLinesXZ(Vector3 positionA, Vector3 velocityA, Vector3 positionB, Vector3 velocityB, out float s, out float t, double parallelTest = double.Epsilon)
		{
			s = default(float);
			t = default(float);
			return false;
		}

		public static bool ClosestPointsOnTwoLineSegments(Vector3 a, Vector3 aLineVector, Vector3 b, Vector3 bLineVector, out Vector3 resultA, out Vector3 resultB, double parallelTest = double.Epsilon)
		{
			resultA = default(Vector3);
			resultB = default(Vector3);
			return false;
		}

		public static Vector3 ClosestPointOnLineSegment(Vector3 point, Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		public static void ClosestPolygonApproach(List<Vector3> verticesA, List<Vector3> verticesB, out Vector3 pointA, out Vector3 pointB, float parallelTest = 0f)
		{
			pointA = default(Vector3);
			pointB = default(Vector3);
		}

		public static bool PointInPolygon(Vector3 testPoint, List<Vector3> vertices)
		{
			return false;
		}

		public static bool PointInPolygon3D(Vector3 testPoint, List<Vector3> vertices)
		{
			return false;
		}

		public static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
		{
			return default(Vector3);
		}

		public static bool ConvexHull2D(List<Vector3> points, List<Vector3> hull)
		{
			return false;
		}

		public static Vector3 PolygonCentroid2D(List<Vector3> vertices)
		{
			return default(Vector3);
		}

		public static Vector2 OrientedMinimumBoundingBox2D(List<Vector3> convexHull, Vector3[] boundingBox)
		{
			return default(Vector2);
		}

		private static void RotateCalipers(Vector3 alignEdge, List<Vector3> vertices, ref int indexA, out int indexB, out int indexC, out int indexD, out Vector3 caliperA, out Vector3 caliperB, out Vector3 caliperC, out Vector3 caliperD, out Vector3 caliperAEndCorner, out Vector3 caliperBEndCorner, out Vector3 caliperCEndCorner, out Vector3 caliperDEndCorner)
		{
			indexB = default(int);
			indexC = default(int);
			indexD = default(int);
			caliperA = default(Vector3);
			caliperB = default(Vector3);
			caliperC = default(Vector3);
			caliperD = default(Vector3);
			caliperAEndCorner = default(Vector3);
			caliperBEndCorner = default(Vector3);
			caliperCEndCorner = default(Vector3);
			caliperDEndCorner = default(Vector3);
		}

		public static Quaternion RotationForBox(Vector3[] vertices)
		{
			return default(Quaternion);
		}

		public static float ConvexPolygonArea(List<Vector3> vertices)
		{
			return 0f;
		}

		public static bool PolygonInPolygon(List<Vector3> polygonA, List<Vector3> polygonB)
		{
			return false;
		}

		public static bool PolygonsWithinRange(List<Vector3> polygonA, List<Vector3> polygonB, float maxDistance)
		{
			return false;
		}

		public static bool PolygonsWithinSqRange(List<Vector3> polygonA, List<Vector3> polygonB, float maxSqDistance)
		{
			return false;
		}

		public static bool PointOnPolygonBoundsXZ(Vector3 testPoint, List<Vector3> vertices, float epsilon = float.Epsilon)
		{
			return false;
		}

		public static bool PointOnLineSegmentXZ(Vector3 testPoint, Vector3 lineStart, Vector3 lineEnd, float epsilon = float.Epsilon)
		{
			return false;
		}

		private static Quaternion NormalizeRotationKeepingUp(Quaternion rot)
		{
			return default(Quaternion);
		}

		public static Pose PolygonUVPoseFromPlanePose(Pose pose)
		{
			return default(Pose);
		}

		public static Vector2 PolygonVertexToUV(Vector3 vertexPos, Pose planePose, Pose uvPose)
		{
			return default(Vector2);
		}
	}
}
