using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	public sealed class GraphGroup : GraphElement<IGraph>
	{
		[DoNotSerialize]
		public static readonly Color defaultColor;

		[Serialize]
		public Rect position
		{
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[Serialize]
		public string label
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
		public string comment
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
		[Inspectable]
		public Color color
		{
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public GraphGroup()
		{
			((GraphElement<>)(object)this)._002Ector();
		}
	}
}
