using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Physics 2D")]
	public abstract class TriggerEvent2DUnit : GameObjectEventUnit<Collider2D>
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

		protected override void AssignArguments(Flow flow, Collider2D other)
		{
		}

		protected TriggerEvent2DUnit()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
