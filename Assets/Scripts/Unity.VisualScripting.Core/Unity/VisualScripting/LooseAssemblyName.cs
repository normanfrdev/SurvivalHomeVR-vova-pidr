using System.Reflection;

namespace Unity.VisualScripting
{
	public struct LooseAssemblyName
	{
		public readonly string name;

		public LooseAssemblyName(string name)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(LooseAssemblyName a, LooseAssemblyName b)
		{
			return false;
		}

		public static bool operator !=(LooseAssemblyName a, LooseAssemblyName b)
		{
			return false;
		}

		public static implicit operator LooseAssemblyName(string name)
		{
			return default(LooseAssemblyName);
		}

		public static implicit operator string(LooseAssemblyName name)
		{
			return null;
		}

		public static explicit operator LooseAssemblyName(AssemblyName strongAssemblyName)
		{
			return default(LooseAssemblyName);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
