using System.Runtime.CompilerServices;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion
{
	public class XROriginMovement : IXRBodyTransformation
	{
		public Vector3 motion
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool forceUnconstrained
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual void Apply(XRMovableBody body)
		{
		}
	}
}
