using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	public class StickyNote : GraphElement<IGraph>
	{
		public enum ColorEnum
		{
			Classic = 0,
			Black = 1,
			Dark = 2,
			Orange = 3,
			Green = 4,
			Blue = 5,
			Red = 6,
			Purple = 7,
			Teal = 8
		}

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
		[InspectorTextArea(minLines = 1f)]
		public string body
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
		public ColorEnum colorTheme
		{
			[CompilerGenerated]
			get
			{
				return default(ColorEnum);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public StickyNote()
		{
			((GraphElement<>)(object)this)._002Ector();
		}

		public static Color GetStickyColor(ColorEnum enumValue)
		{
			return default(Color);
		}

		public static Color GetFontColor(ColorEnum enumValue)
		{
			return default(Color);
		}
	}
}
