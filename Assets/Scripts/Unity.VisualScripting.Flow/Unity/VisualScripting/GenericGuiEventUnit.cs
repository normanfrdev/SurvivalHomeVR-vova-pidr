using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace Unity.VisualScripting
{
	public abstract class GenericGuiEventUnit : GameObjectEventUnit<BaseEventData>
	{
		[DoNotSerialize]
		[PortLabelHidden]
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

		protected override void AssignArguments(Flow flow, BaseEventData data)
		{
		}

		protected GenericGuiEventUnit()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
