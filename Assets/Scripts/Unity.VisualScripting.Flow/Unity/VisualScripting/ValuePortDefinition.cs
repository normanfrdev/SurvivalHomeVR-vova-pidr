using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public abstract class ValuePortDefinition : UnitPortDefinition, IUnitValuePortDefinition, IUnitPortDefinition
	{
		[SerializeAs("_type")]
		private Type _type
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

		[Inspectable]
		[DoNotSerialize]
		public virtual Type type
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool isValid => false;
	}
}
