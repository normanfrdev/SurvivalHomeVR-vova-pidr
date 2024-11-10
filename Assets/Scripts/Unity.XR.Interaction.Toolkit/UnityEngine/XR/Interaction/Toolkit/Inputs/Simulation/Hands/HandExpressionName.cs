using System;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation.Hands
{
	internal readonly struct HandExpressionName : IEquatable<HandExpressionName>
	{
		public static readonly HandExpressionName Default;

		private readonly InternedString m_InternedString;

		public HandExpressionName(string value)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(HandExpressionName other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(HandExpressionName lhs, HandExpressionName rhs)
		{
			return false;
		}

		public static bool operator !=(HandExpressionName lhs, HandExpressionName rhs)
		{
			return false;
		}

		public static implicit operator string(HandExpressionName value)
		{
			return null;
		}

		public static implicit operator HandExpressionName(string value)
		{
			return default(HandExpressionName);
		}
	}
}
