using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[IncludeInSettings(false)]
	public sealed class VariablesAsset : LudiqScriptableObject
	{
		[Serialize]
		[Inspectable]
		[InspectorWide(true)]
		public VariableDeclarations declarations
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		[ContextMenu("Show Data...")]
		protected override void ShowData()
		{
		}
	}
}
