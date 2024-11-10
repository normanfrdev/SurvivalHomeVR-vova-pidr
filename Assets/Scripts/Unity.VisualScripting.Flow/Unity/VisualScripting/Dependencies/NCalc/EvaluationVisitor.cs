using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class EvaluationVisitor : LogicalExpressionVisitor
	{
		private delegate T Func<T>();

		private readonly Flow flow;

		private readonly EvaluateOptions options;

		private bool IgnoreCase => false;

		public object Result
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

		public Dictionary<string, object> Parameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public event EvaluateFunctionHandler EvaluateFunction
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EvaluateParameterHandler EvaluateParameter
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public EvaluationVisitor(Flow flow, EvaluateOptions options)
		{
		}

		private object Evaluate(LogicalExpression expression)
		{
			return null;
		}

		public override void Visit(TernaryExpression ternary)
		{
		}

		public override void Visit(BinaryExpression binary)
		{
		}

		public override void Visit(UnaryExpression unary)
		{
		}

		public override void Visit(ValueExpression value)
		{
		}

		public override void Visit(FunctionExpression function)
		{
		}

		private void CheckCase(FunctionExpression function, string reference)
		{
		}

		private void OnEvaluateFunction(string name, FunctionArgs args)
		{
		}

		public override void Visit(IdentifierExpression identifier)
		{
		}

		private void OnEvaluateParameter(string name, ParameterArgs args)
		{
		}

		public static void CheckExactArgumentCount(FunctionExpression function, int count)
		{
		}

		public static void CheckMinArgumentCount(FunctionExpression function, int count)
		{
		}
	}
}
