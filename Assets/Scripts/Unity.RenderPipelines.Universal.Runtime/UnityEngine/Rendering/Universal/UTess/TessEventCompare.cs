using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace UnityEngine.Rendering.Universal.UTess
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct TessEventCompare : IComparer<UEvent>
	{
		public int Compare(UEvent a, UEvent b)
		{
			return 0;
		}
	}
}
