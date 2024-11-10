using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class ValueInputDefinition : ValuePortDefinition, IUnitInputPortDefinition, IUnitPortDefinition
	{
		[SerializeAs("defaultValue")]
		private object _defaultvalue;

		[Inspectable]
		[DoNotSerialize]
		public override Type type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Serialize]
		[Inspectable]
		public bool hasDefaultValue
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
		[Inspectable]
		public object defaultValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
