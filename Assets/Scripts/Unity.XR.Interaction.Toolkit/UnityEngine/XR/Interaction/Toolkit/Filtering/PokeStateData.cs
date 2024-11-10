using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	public struct PokeStateData : IEquatable<PokeStateData>
	{
		public bool meetsRequirements
		{
			[CompilerGenerated]
			readonly get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 pokeInteractionPoint
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 axisAlignedPokeInteractionPoint
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float interactionStrength
		{
			[CompilerGenerated]
			readonly get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 axisNormal
		{
			[CompilerGenerated]
			readonly get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Transform target
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Equals(PokeStateData other)
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
	}
}
