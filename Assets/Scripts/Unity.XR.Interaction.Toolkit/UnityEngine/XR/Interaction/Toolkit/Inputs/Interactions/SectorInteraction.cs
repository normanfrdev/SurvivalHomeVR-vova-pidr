using System;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Interactions
{
	[Preserve]
	public class SectorInteraction : IInputInteraction<Vector2>, IInputInteraction
	{
		[Flags]
		public enum Directions
		{
			None = 0,
			North = 1,
			South = 2,
			East = 4,
			West = 8
		}

		public enum SweepBehavior
		{
			Locked = 0,
			AllowReentry = 1,
			DisallowReentry = 2,
			HistoryIndependent = 3
		}

		private enum State
		{
			Centered = 0,
			StartedValidDirection = 1,
			StartedInvalidDirection = 2
		}

		public Directions directions;

		public SweepBehavior sweepBehavior;

		public float pressPoint;

		private State m_State;

		private bool m_WasValidDirection;

		internal float pressPointOrDefault => 0f;

		public static float defaultPressPoint
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Process(ref InputInteractionContext context)
		{
		}

		private bool IsValidDirection(ref InputInteractionContext context)
		{
			return false;
		}

		private static Directions GetNearestDirection(Cardinal value)
		{
			return default(Directions);
		}

		public void Reset()
		{
		}

		[Preserve]
		static SectorInteraction()
		{
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		[Preserve]
		private static void Initialize()
		{
		}
	}
}
