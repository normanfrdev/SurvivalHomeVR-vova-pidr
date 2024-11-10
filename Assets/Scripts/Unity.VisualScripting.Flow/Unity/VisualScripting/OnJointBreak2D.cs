using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Physics 2D")]
	public sealed class OnJointBreak2D : GameObjectEventUnit<Joint2D>
	{
		public override Type MessageListenerType => null;

		protected override string hookName => null;

		[DoNotSerialize]
		public ValueOutput breakForce
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
		public ValueOutput breakTorque
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
		public ValueOutput connectedBody
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
		public ValueOutput reactionForce
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
		public ValueOutput reactionTorque
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
		public ValueOutput joint
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

		protected override void AssignArguments(Flow flow, Joint2D joint)
		{
		}

		public OnJointBreak2D()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
