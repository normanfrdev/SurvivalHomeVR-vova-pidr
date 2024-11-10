using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public readonly struct ARTrackablesParentTransformChangedEventArgs : IEquatable<ARTrackablesParentTransformChangedEventArgs>
	{
		public XROrigin Origin
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Transform TrackablesParent
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ARTrackablesParentTransformChangedEventArgs(XROrigin origin, Transform trackablesParent)
		{
		}

		public bool Equals(ARTrackablesParentTransformChangedEventArgs other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(ARTrackablesParentTransformChangedEventArgs lhs, ARTrackablesParentTransformChangedEventArgs rhs)
		{
			return false;
		}

		public static bool operator !=(ARTrackablesParentTransformChangedEventArgs lhs, ARTrackablesParentTransformChangedEventArgs rhs)
		{
			return false;
		}
	}
}
