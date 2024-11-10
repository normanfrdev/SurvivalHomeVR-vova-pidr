using System.Runtime.CompilerServices;
using Unity.VisualScripting.Dependencies.NCalc;

namespace Unity.VisualScripting
{
	public sealed class Formula : MultiInputUnit<object>
	{
		[SerializeAs("Formula")]
		private string _formula;

		private Expression ncalc;

		[DoNotSerialize]
		[Inspectable]
		[UnitHeaderInspectable]
		[InspectorTextArea]
		public string formula
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Serialize]
		[Inspectable(order = int.MaxValue)]
		[InspectorExpandTooltip]
		public bool cacheArguments
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		[DoNotSerialize]
		[PortLabelHidden]
		public ValueOutput result
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

		protected override int minInputCount => 0;

		protected override void Definition()
		{
		}

		private void InitializeNCalc()
		{
		}

		private object Evaluate(Flow flow)
		{
			return null;
		}

		private void EvaluateTreeFunction(Flow flow, string name, FunctionArgs args)
		{
		}

		public object GetParameterValue(Flow flow, string name)
		{
			return null;
		}

		private void EvaluateTreeParameter(Flow flow, string name, ParameterArgs args)
		{
		}

		public static string GetArgumentName(int index)
		{
			return null;
		}

		public static int GetArgumentIndex(char name)
		{
			return 0;
		}

		public Formula()
		{
			((MultiInputUnit<>)(object)this)._002Ector();
		}
	}
}
