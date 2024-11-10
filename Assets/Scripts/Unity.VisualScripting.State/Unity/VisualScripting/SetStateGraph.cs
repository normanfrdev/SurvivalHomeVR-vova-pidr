using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.VisualScripting
{
	[TypeIcon(typeof(StateGraph))]
	public class SetStateGraph : SetGraph<StateGraph, StateGraphAsset, StateMachine>
	{
		[Serialize]
		[Inspectable]
		[UnitHeaderInspectable]
		[UsedImplicitly]
		public StateGraphContainerType containerType
		{
			[CompilerGenerated]
			get
			{
				return default(StateGraphContainerType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override bool isGameObject => false;

		public SetStateGraph()
		{
			((SetGraph<TGraph, TMacro, TMachine>)(object)this)._002Ector();
		}
	}
}
