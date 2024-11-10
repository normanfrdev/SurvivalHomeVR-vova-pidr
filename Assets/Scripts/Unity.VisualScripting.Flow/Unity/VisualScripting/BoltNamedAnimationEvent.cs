using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Animation")]
	[UnitShortTitle("Animation Event")]
	[UnitTitle("Named Animation Event")]
	[TypeIcon(typeof(AnimationClip))]
	[DisplayName("Visual Scripting Named Animation Event")]
	public sealed class BoltNamedAnimationEvent : MachineEventUnit<AnimationEvent>
	{
		protected override string hookName => null;

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
		[PortLabel("Float")]
		public ValueOutput floatParameter
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
		[PortLabel("Integer")]
		public ValueOutput intParameter
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
		[PortLabel("Object")]
		public ValueOutput objectReferenceParameter
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

		protected override bool ShouldTrigger(Flow flow, AnimationEvent animationEvent)
		{
			return false;
		}

		protected override void AssignArguments(Flow flow, AnimationEvent animationEvent)
		{
		}

		public BoltNamedAnimationEvent()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
