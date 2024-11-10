using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Physics")]
	public abstract class CollisionEventUnit : GameObjectEventUnit<Collision>
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

		[DoNotSerialize]
		public ValueOutput contacts
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

		[DoNotSerialize]
		public ValueOutput impulse
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

		[DoNotSerialize]
		public ValueOutput relativeVelocity
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

		[DoNotSerialize]
		public ValueOutput data
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

		protected override void AssignArguments(Flow flow, Collision collision)
		{
		}

		protected CollisionEventUnit()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
