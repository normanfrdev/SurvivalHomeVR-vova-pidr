using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering.Universal.UTess
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct XCompare : IComparer<double>
	{
		public int Compare(double a, double b)
		{
			return 0;
		}
	}
}
