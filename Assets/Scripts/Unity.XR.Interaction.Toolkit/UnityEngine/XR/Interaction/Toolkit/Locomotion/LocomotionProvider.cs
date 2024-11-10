using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion
{
	[DefaultExecutionOrder(-210)]
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public abstract class LocomotionProvider : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The behavior that this provider communicates with for access to the mediator's XR Body Transformer. If one is not provided, this provider will attempt to locate one during its Awake call.")]
		private LocomotionMediator m_Mediator;

		[SerializeField]
		[Tooltip("The queue order of this provider's transformations of the XR Origin. The lower the value, the earlier the transformations are applied.")]
		private int m_TransformationPriority;

		private XRBodyTransformer m_ActiveBodyTransformer;

		private bool m_AnyTransformationsThisFrame;

		[Tooltip("(Deprecated) The Locomotion System that this locomotion provider communicates with for exclusive access to an XR Origin. If one is not provided, the behavior will attempt to locate one during its Awake call.")]
		[Obsolete("LocomotionSystem is deprecated in XRI 3.0.0 and will be removed in a future release. Use mediator instead.", false)]
		private LocomotionSystem m_System;

		public LocomotionMediator mediator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int transformationPriority
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public LocomotionState locomotionState => default(LocomotionState);

		public bool isLocomotionActive => false;

		public virtual bool canStartMoving => false;

		[Obsolete("LocomotionSystem is deprecated in XRI 3.0.0 and will be removed in a future release. Use mediator instead.", false)]
		public LocomotionSystem system
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete("locomotionPhase is deprecated in XRI 3.0.0 and will be removed in a future release. Use locomotionState instead.", false)]
		public LocomotionPhase locomotionPhase
		{
			[CompilerGenerated]
			get
			{
				return default(LocomotionPhase);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public event Action<LocomotionProvider> locomotionStarted
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

		public event Action<LocomotionProvider> locomotionEnded
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

		public event Action<LocomotionProvider> beforeStepLocomotion
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

		[Obsolete("startLocomotion has been deprecated in XRI 3.0.0. Use beginLocomotion instead. (UnityUpgradable) -> beginLocomotion", true)]
		public event Action<LocomotionSystem> startLocomotion
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

		[Obsolete("beginLocomotion is deprecated in XRI 3.0.0 and will be removed in a future release. Use locomotionStarted instead.", false)]
		public event Action<LocomotionSystem> beginLocomotion
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

		[Obsolete("endLocomotion is deprecated in XRI 3.0.0 and will be removed in a future release. Use locomotionEnded instead.", false)]
		public event Action<LocomotionSystem> endLocomotion
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

		protected virtual void Awake()
		{
		}

		protected bool TryPrepareLocomotion()
		{
			return false;
		}

		protected bool TryStartLocomotionImmediately()
		{
			return false;
		}

		protected bool TryEndLocomotion()
		{
			return false;
		}

		internal void OnLocomotionStart(XRBodyTransformer transformer)
		{
		}

		protected virtual void OnLocomotionStarting()
		{
		}

		internal void OnLocomotionEnd()
		{
		}

		protected virtual void OnLocomotionEnding()
		{
		}

		protected bool TryQueueTransformation(IXRBodyTransformation bodyTransformation)
		{
			return false;
		}

		protected bool TryQueueTransformation(IXRBodyTransformation bodyTransformation, int priority)
		{
			return false;
		}

		private bool CanQueueTransformation()
		{
			return false;
		}

		private void OnBeforeTransformationsApplied(XRBodyTransformer bodyTransformer)
		{
		}

		[Obsolete("CanBeginLocomotion is deprecated in XRI 3.0.0 and will be removed in a future release. Instead, query isLocomotionActive to check if locomotion can start.", false)]
		protected bool CanBeginLocomotion()
		{
			return false;
		}

		[Obsolete("BeginLocomotion is deprecated in XRI 3.0.0 and will be removed in a future release. Instead, call TryPrepareLocomotion when locomotion start input occurs.", false)]
		protected bool BeginLocomotion()
		{
			return false;
		}

		[Obsolete("EndLocomotion is deprecated in XRI 3.0.0 and will be removed in a future release. Instead, call TryEndLocomotion when locomotion end input has completed.", false)]
		protected bool EndLocomotion()
		{
			return false;
		}
	}
}
