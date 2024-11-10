using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion
{
	public class DelegateXRBodyTransformation : IXRBodyTransformation
	{
		public event Action<XRMovableBody> transformation
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public DelegateXRBodyTransformation()
		{
		}

		public DelegateXRBodyTransformation(Action<XRMovableBody> transformation)
		{
		}

		public void Apply(XRMovableBody body)
		{
		}
	}
}
