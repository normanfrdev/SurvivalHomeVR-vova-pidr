using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites
{
	[Preserve]
	public abstract class FallbackComposite<TValue> : InputBindingComposite<TValue> where TValue : struct
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		internal struct QuaternionCompositeComparer : IComparer<Quaternion>
		{
			public int Compare(Quaternion x, Quaternion y)
			{
				return 0;
			}
		}

		protected FallbackComposite()
		{
			((InputBindingComposite<TValue>)(object)this)._002Ector();
		}
	}
}
