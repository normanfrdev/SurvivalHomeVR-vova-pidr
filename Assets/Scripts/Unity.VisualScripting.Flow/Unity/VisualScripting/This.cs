using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[SpecialUnit]
	[RenamedFrom("Bolt.Self")]
	[RenamedFrom("Unity.VisualScripting.Self")]
	public sealed class This : Unit
	{
		[DoNotSerialize]
		[PortLabelHidden]
		[PortLabel("This")]
		public ValueOutput self
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

		protected override void Definition()
		{
		}

		private GameObject Result(Flow flow)
		{
			return null;
		}

		private bool IsPredictable(Flow flow)
		{
			return false;
		}
	}
}
