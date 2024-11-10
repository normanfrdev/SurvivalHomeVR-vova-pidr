using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Physics")]
	public abstract class TriggerEventUnit : GameObjectEventUnit<Collider>
	{
		[DoNotSerialize]
		public ValueOutput collider
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

		protected override void AssignArguments(Flow flow, Collider other)
		{
		}

		protected TriggerEventUnit()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
