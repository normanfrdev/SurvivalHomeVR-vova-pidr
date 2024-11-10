using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public abstract class Graph : IGraph, IDisposable, IPrewarmable, IAotStubbable, ISerializationDepender, ISerializationCallbackReceiver
	{
		[SerializeAs("elements")]
		private List<IGraphElement> _elements;

		private bool prewarmed;

		[DoNotSerialize]
		public MergedGraphElementCollection elements
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Serialize]
		public string title
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

		[Serialize]
		[InspectorTextArea(minLines = 1f, maxLines = 10f)]
		public string summary
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

		[Serialize]
		public Vector2 pan
		{
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Serialize]
		public float zoom
		{
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IEnumerable<ISerializationDependency> deserializationDependencies => null;

		public override string ToString()
		{
			return null;
		}

		public abstract IGraphData CreateData();

		public virtual IGraphDebugData CreateDebugData()
		{
			return null;
		}

		public virtual void Instantiate(GraphReference instance)
		{
		}

		public virtual void Uninstantiate(GraphReference instance)
		{
		}

		public virtual void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public virtual void OnAfterDependenciesDeserialized()
		{
		}

		public IEnumerable<object> GetAotStubs(HashSet<object> visited)
		{
			return null;
		}

		public void Prewarm()
		{
		}

		public virtual void Dispose()
		{
		}
	}
}
