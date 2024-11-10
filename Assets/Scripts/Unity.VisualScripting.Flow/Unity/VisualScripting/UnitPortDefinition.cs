using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public abstract class UnitPortDefinition : IUnitPortDefinition
	{
		[Serialize]
		[Inspectable]
		[InspectorDelayed]
		[WarnBeforeEditing("Edit Port Key", "Changing the key of this definition will break any existing connection to this port. Are you sure you want to continue?", new object[] { null, "" })]
		public string key
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
		[Inspectable]
		[InspectorTextArea]
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
		[Inspectable]
		public bool hideLabel
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

		[DoNotSerialize]
		public virtual bool isValid => false;
	}
}
