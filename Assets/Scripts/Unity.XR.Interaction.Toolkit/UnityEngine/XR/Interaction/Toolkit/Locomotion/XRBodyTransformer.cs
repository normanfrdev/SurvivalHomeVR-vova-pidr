using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.XR.CoreUtils;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Internal;

namespace UnityEngine.XR.Interaction.Toolkit.Locomotion
{
	[AddComponentMenu("XR/Locomotion/XR Body Transformer", 11)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.Locomotion.XRBodyTransformer.html")]
	[DefaultExecutionOrder(-205)]
	public class XRBodyTransformer : MonoBehaviour
	{
		private struct OrderedTransformation
		{
			public IXRBodyTransformation transformation;

			public int priority;
		}

		[SerializeField]
		[Tooltip("The XR Origin to transform (will find one if None).")]
		private XROrigin m_XROrigin;

		[SerializeField]
		[RequireInterface(typeof(IXRBodyPositionEvaluator))]
		[Tooltip("Object that determines the position of the user's body. If set to None, this behavior will estimate the position to be the camera position projected onto the XZ plane of the XR Origin.")]
		private Object m_BodyPositionEvaluatorObject;

		private IXRBodyPositionEvaluator m_BodyPositionEvaluator;

		[SerializeField]
		[RequireInterface(typeof(IConstrainedXRBodyManipulator))]
		[Tooltip("Object used to perform movement that is constrained by collision (optional, may be None).")]
		private Object m_ConstrainedBodyManipulatorObject;

		private IConstrainedXRBodyManipulator m_ConstrainedBodyManipulator;

		[SerializeField]
		[Tooltip("When enabled and if a Constrained Manipulator is not already assigned, this behavior will use the XR Origin's Character Controller to perform constrained movement, if one exists on the XR Origin's base GameObject.")]
		private bool m_UseCharacterControllerIfExists;

		private bool m_UsingDynamicBodyPositionEvaluator;

		private bool m_UsingDynamicConstrainedBodyManipulator;

		private XRMovableBody m_MovableBody;

		private readonly LinkedList<OrderedTransformation> m_TransformationsQueue;

		public XROrigin xrOrigin
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IXRBodyPositionEvaluator bodyPositionEvaluator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IConstrainedXRBodyManipulator constrainedBodyManipulator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool useCharacterControllerIfExists
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action<XRBodyTransformer> beforeApplyTransformations
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

		protected virtual void Reset()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		private void InitializeMovableBody()
		{
		}

		public void QueueTransformation(IXRBodyTransformation transformation, int priority = 0)
		{
		}
	}
}
