using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation
{
	[AddComponentMenu("XR/Locomotion/Teleportation Provider", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.Teleportation.TeleportationProvider.html")]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public class TeleportationProvider : LocomotionProvider
	{
		[SerializeField]
		[Tooltip("The time (in seconds) to delay the teleportation once it is activated.")]
		private float m_DelayTime;

		private float m_DelayStartTime;

		protected TeleportRequest currentRequest
		{
			[CompilerGenerated]
			get
			{
				return default(TeleportRequest);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool validRequest
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

		public float delayTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool canStartMoving => false;

		public XROriginUpAlignment upTransformation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public XRCameraForwardXZAlignment forwardTransformation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public XRBodyGroundPosition positionTransformation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public virtual bool QueueTeleportRequest(TeleportRequest teleportRequest)
		{
			return false;
		}

		protected virtual void Update()
		{
		}
	}
}
