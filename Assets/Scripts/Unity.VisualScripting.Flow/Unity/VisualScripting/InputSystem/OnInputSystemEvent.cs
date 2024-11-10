using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Unity.VisualScripting.InputSystem
{
	[UnitCategory("Events/Input")]
	public abstract class OnInputSystemEvent : MachineEventUnit<EmptyEventArgs>
	{
		private new class Data : EventUnit<EmptyEventArgs>.Data
		{
			internal InputAction Action;

			public Data()
			{
				((EventUnit<>.Data)(object)this)._002Ector();
			}
		}

		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable]
		public InputActionChangeOption InputActionChangeType;

		private Vector2 m_Value;

		protected override string hookName => null;

		protected abstract OutputType OutputType { get; }

		[DoNotSerialize]
		public ValueInput InputAction
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
		[PortLabelHidden]
		[NullMeansSelf]
		public ValueInput Target
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

		[PortLabelHidden]
		public ValueOutput FloatValue
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

		[PortLabelHidden]
		public ValueOutput Vector2Value
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

		public override IGraphElementData CreateData()
		{
			return null;
		}

		protected override void Definition()
		{
		}

		public override void StartListening(GraphStack stack)
		{
		}

		public override void StopListening(GraphStack stack)
		{
		}

		protected override bool ShouldTrigger(Flow flow, EmptyEventArgs args)
		{
			return false;
		}

		private void DoAssignArguments(Flow flow, Data data)
		{
		}

		protected OnInputSystemEvent()
		{
			((MachineEventUnit<>)(object)this)._002Ector();
		}
	}
}
