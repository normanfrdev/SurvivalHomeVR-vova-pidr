using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Utilities
{
	public struct NamedValue : IEquatable<NamedValue>
	{
		public const string Separator = ",";

		public string name
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

		public PrimitiveValue value
		{
			[CompilerGenerated]
			readonly get
			{
				return default(PrimitiveValue);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TypeCode type => default(TypeCode);

		public NamedValue ConvertTo(TypeCode type)
		{
			return default(NamedValue);
		}

		public static NamedValue From<TValue>(string name, TValue value) where TValue : struct
		{
			return default(NamedValue);
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(NamedValue other)
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

		public static bool operator ==(NamedValue left, NamedValue right)
		{
			return false;
		}

		public static bool operator !=(NamedValue left, NamedValue right)
		{
			return false;
		}

		public static NamedValue[] ParseMultiple(string parameterString)
		{
			return null;
		}

		public static NamedValue Parse(string str)
		{
			return default(NamedValue);
		}

		private static NamedValue ParseParameter(string parameterString, ref int index)
		{
			return default(NamedValue);
		}

		public void ApplyToObject(object instance)
		{
		}

		public static void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters) where TParameterList : IEnumerable<NamedValue>
		{
		}
	}
}
