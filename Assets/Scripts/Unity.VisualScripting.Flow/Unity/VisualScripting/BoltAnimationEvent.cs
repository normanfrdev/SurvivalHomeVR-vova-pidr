using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[UnitCategory("Events/Animation")]
	[UnitShortTitle("Animation Event")]
	[UnitTitle("Animation Event")]
	[TypeIcon(typeof(AnimationClip))]
	[DisplayName("Visual Scripting Animation Event")]
	public sealed class BoltAnimationEvent : MachineEventUnit<AnimationEvent>
	{
		protected override string hookName => null;

		[DoNotSerialize]
		[PortLabel("String")]
		public ValueOutput stringParameter
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

		protected override void AssignArguments(Flow flow, AnimationEvent args)
		{
		}

		public BoltAnimationEvent()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
