using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public readonly struct AffordanceStateData : IEquatable<AffordanceStateData>
	{
		public const byte totalStateTransitionIncrements = byte.MaxValue;

		public byte stateIndex
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public byte stateTransitionIncrement
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public float stateTransitionAmountFloat => 0f;

		public AffordanceStateData(byte stateIndex, float transitionAmount)
		{
		}

		public AffordanceStateData(byte stateIndex, byte transitionIncrement)
		{
		}

		public bool Equals(AffordanceStateData other)
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
