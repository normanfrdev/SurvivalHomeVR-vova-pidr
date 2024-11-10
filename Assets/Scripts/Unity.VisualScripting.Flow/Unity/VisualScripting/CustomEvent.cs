using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Events")]
	[UnitOrder(0)]
	public sealed class CustomEvent : GameObjectEventUnit<CustomEventArgs>
	{
		[SerializeAs("argumentCount")]
		private int _argumentCount;

		public override Type MessageListenerType => null;

		protected override string hookName => null;

		[DoNotSerialize]
		[Inspectable]
		[UnitHeaderInspectable("Arguments")]
		public int argumentCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueInput name
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
		public List<ValueOutput> argumentPorts
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected override void Definition()
		{
		}

		protected override bool ShouldTrigger(Flow flow, CustomEventArgs args)
		{
			return false;
		}

		protected override void AssignArguments(Flow flow, CustomEventArgs args)
		{
		}

		public static void Trigger(GameObject target, string name, params object[] args)
		{
		}

		public CustomEvent()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
