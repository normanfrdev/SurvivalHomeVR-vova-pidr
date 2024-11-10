using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public abstract class MultiInputUnit<T> : Unit, IMultiInputUnit, IUnit, IGraphElementWithDebugData, IGraphElement, IGraphItem, INotifiedCollectionItem, IDisposable, IPrewarmable, IAotStubbable, IIdentifiable, IAnalyticsIdentifiable
	{
		[SerializeAs("inputCount")]
		private int _inputCount;

		[DoNotSerialize]
		protected virtual int minInputCount => 0;

		[DoNotSerialize]
		[Inspectable]
		[UnitHeaderInspectable("Inputs")]
		public virtual int inputCount
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
		public ReadOnlyCollection<ValueInput> multiInputs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected override void Definition()
		{
		}

		protected void InputsAllowNull()
		{
		}

		FlowGraph IUnit.get_graph()
		{
			return null;
		}
	}
}
