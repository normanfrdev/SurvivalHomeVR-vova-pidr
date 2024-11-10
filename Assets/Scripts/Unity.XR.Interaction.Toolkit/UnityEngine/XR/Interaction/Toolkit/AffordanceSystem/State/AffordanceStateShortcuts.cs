using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public static class AffordanceStateShortcuts
	{
		public const byte disabled = 0;

		public const byte idle = 1;

		public const byte hovered = 2;

		public const byte hoveredPriority = 3;

		public const byte selected = 4;

		public const byte activated = 5;

		public const byte focused = 6;

		private static readonly Dictionary<byte, string> k_StateNames;

		public static AffordanceStateData disabledState
		{
			[CompilerGenerated]
			get
			{
				return default(AffordanceStateData);
			}
		}

		public static AffordanceStateData idleState
		{
			[CompilerGenerated]
			get
			{
				return default(AffordanceStateData);
			}
		}

		public static AffordanceStateData hoveredState
		{
			[CompilerGenerated]
			get
			{
				return default(AffordanceStateData);
			}
		}

		public static AffordanceStateData hoveredPriorityState
		{
			[CompilerGenerated]
			get
			{
				return default(AffordanceStateData);
			}
		}

		public static AffordanceStateData selectedState
		{
			[CompilerGenerated]
			get
			{
				return default(AffordanceStateData);
			}
		}

		public static AffordanceStateData activatedState
		{
			[CompilerGenerated]
			get
			{
				return default(AffordanceStateData);
			}
		}

		public static AffordanceStateData focusedState
		{
			[CompilerGenerated]
			get
			{
				return default(AffordanceStateData);
			}
		}

		internal static byte stateCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		internal static string GetNameForIndex(byte index)
		{
			return null;
		}
	}
}
