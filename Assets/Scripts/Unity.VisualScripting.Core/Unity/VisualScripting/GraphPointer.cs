using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.VisualScripting
{
	public abstract class GraphPointer
	{
		protected readonly List<IGraphParent> parentStack;

		protected readonly List<IGraphParentElement> parentElementStack;

		protected readonly List<IGraph> graphStack;

		protected readonly List<IGraphData> dataStack;

		protected readonly List<IGraphDebugData> debugDataStack;

		internal static Action<IGraphRoot> releaseDebugDataBinding;

		public IGraphRoot root
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public UnityEngine.Object rootObject => null;

		public IMachine machine => null;

		public IMacro macro => null;

		public MonoBehaviour component => null;

		public GameObject gameObject
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public GameObject self => null;

		public ScriptableObject scriptableObject => null;

		public Scene? scene => null;

		public UnityEngine.Object serializedObject => null;

		public IEnumerable<Guid> parentElementGuids => null;

		public int depth => 0;

		public bool isRoot => false;

		public bool isChild => false;

		public IGraphParent parent => null;

		public IGraphParentElement parentElement => null;

		public IGraph rootGraph => null;

		public IGraph graph => null;

		protected IGraphData _data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IGraphData data => null;

		protected IGraphData _parentData => null;

		public bool hasData => false;

		public static Func<IGraphRoot, IGraphDebugData> fetchRootDebugDataBinding
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

		public bool hasDebugData => false;

		protected IGraphDebugData _debugData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IGraphDebugData debugData => null;

		public bool isValid => false;

		protected static bool IsValidRoot(IGraphRoot root)
		{
			return false;
		}

		protected static bool IsValidRoot(UnityEngine.Object rootObject)
		{
			return false;
		}

		internal GraphPointer()
		{
		}

		protected void Initialize(IGraphRoot root)
		{
		}

		protected void Initialize(IGraphRoot root, IEnumerable<IGraphParentElement> parentElements, bool ensureValid)
		{
		}

		protected void Initialize(UnityEngine.Object rootObject, IEnumerable<Guid> parentElementGuids, bool ensureValid)
		{
		}

		public abstract GraphReference AsReference();

		public virtual void CopyFrom(GraphPointer other)
		{
		}

		public void EnsureDepthValid(int depth)
		{
		}

		public void EnsureChild()
		{
		}

		public bool IsWithin<T>() where T : IGraphParent
		{
			return false;
		}

		public void EnsureWithin<T>() where T : IGraphParent
		{
		}

		public T GetParent<T>() where T : IGraphParent
		{
			return default(T);
		}

		public void EnsureDataAvailable()
		{
		}

		public T GetGraphData<T>() where T : IGraphData
		{
			return default(T);
		}

		public T GetElementData<T>(IGraphElementWithData element) where T : IGraphElementData
		{
			return default(T);
		}

		public void EnsureDebugDataAvailable()
		{
		}

		public T GetGraphDebugData<T>() where T : IGraphDebugData
		{
			return default(T);
		}

		public T GetElementDebugData<T>(IGraphElementWithDebugData element)
		{
			return default(T);
		}

		protected bool TryEnterParentElement(Guid parentElementGuid, out string error, int? maxRecursionDepth = null)
		{
			error = null;
			return false;
		}

		protected bool TryEnterParentElement(IGraphParentElement parentElement, out string error, int? maxRecursionDepth = null, bool skipContainsCheck = false)
		{
			error = null;
			return false;
		}

		protected void EnterParentElement(IGraphParentElement parentElement)
		{
		}

		protected void EnterParentElement(Guid parentElementGuid)
		{
		}

		private void EnterValidParentElement(IGraphParentElement parentElement)
		{
		}

		protected void ExitParentElement()
		{
		}

		public void EnsureValid()
		{
		}

		public bool InstanceEquals(GraphPointer other)
		{
			return false;
		}

		public bool DefinitionEquals(GraphPointer other)
		{
			return false;
		}

		public int ComputeHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
