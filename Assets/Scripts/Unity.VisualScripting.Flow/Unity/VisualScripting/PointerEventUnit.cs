using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace Unity.VisualScripting
{
	public abstract class PointerEventUnit : GameObjectEventUnit<PointerEventData>
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

		protected override void AssignArguments(Flow flow, PointerEventData data)
		{
		}

		protected PointerEventUnit()
		{
			((GameObjectEventUnit<>)(object)this)._002Ector();
		}
	}
}
