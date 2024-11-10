using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public static class OperatorUtility
	{
		public static readonly Dictionary<string, string> operatorNames;

		public static readonly Dictionary<string, int> operatorRanks;

		private static readonly Dictionary<UnaryOperator, UnaryOperatorHandler> unaryOperatorHandlers;

		private static readonly Dictionary<BinaryOperator, BinaryOperatorHandler> binaryOpeatorHandlers;

		private static readonly LogicalNegationHandler logicalNegationHandler;

		private static readonly NumericNegationHandler numericNegationHandler;

		private static readonly IncrementHandler incrementHandler;

		private static readonly DecrementHandler decrementHandler;

		private static readonly PlusHandler plusHandler;

		private static readonly AdditionHandler additionHandler;

		private static readonly SubtractionHandler subtractionHandler;

		private static readonly MultiplicationHandler multiplicationHandler;

		private static readonly DivisionHandler divisionHandler;

		private static readonly ModuloHandler moduloHandler;

		private static readonly AndHandler andHandler;

		private static readonly OrHandler orHandler;

		private static readonly ExclusiveOrHandler exclusiveOrHandler;

		private static readonly EqualityHandler equalityHandler;

		private static readonly InequalityHandler inequalityHandler;

		private static readonly GreaterThanHandler greaterThanHandler;

		private static readonly LessThanHandler lessThanHandler;

		private static readonly GreaterThanOrEqualHandler greaterThanOrEqualHandler;

		private static readonly LessThanOrEqualHandler lessThanOrEqualHandler;

		private static readonly LeftShiftHandler leftShiftHandler;

		private static readonly RightShiftHandler rightShiftHandler;

		static OperatorUtility()
		{
		}

		public static UnaryOperatorHandler GetHandler(UnaryOperator @operator)
		{
			return null;
		}

		public static BinaryOperatorHandler GetHandler(BinaryOperator @operator)
		{
			return null;
		}

		public static string Symbol(this UnaryOperator @operator)
		{
			return null;
		}

		public static string Symbol(this BinaryOperator @operator)
		{
			return null;
		}

		public static string Name(this UnaryOperator @operator)
		{
			return null;
		}

		public static string Name(this BinaryOperator @operator)
		{
			return null;
		}

		public static string Verb(this UnaryOperator @operator)
		{
			return null;
		}

		public static string Verb(this BinaryOperator @operator)
		{
			return null;
		}

		public static object Operate(UnaryOperator @operator, object x)
		{
			return null;
		}

		public static object Operate(BinaryOperator @operator, object a, object b)
		{
			return null;
		}

		public static object Negate(object x)
		{
			return null;
		}

		public static object Not(object x)
		{
			return null;
		}

		public static object UnaryPlus(object x)
		{
			return null;
		}

		public static object Increment(object x)
		{
			return null;
		}

		public static object Decrement(object x)
		{
			return null;
		}

		public static object And(object a, object b)
		{
			return null;
		}

		public static object Or(object a, object b)
		{
			return null;
		}

		public static object ExclusiveOr(object a, object b)
		{
			return null;
		}

		public static object Add(object a, object b)
		{
			return null;
		}

		public static object Subtract(object a, object b)
		{
			return null;
		}

		public static object Multiply(object a, object b)
		{
			return null;
		}

		public static object Divide(object a, object b)
		{
			return null;
		}

		public static object Modulo(object a, object b)
		{
			return null;
		}

		public static bool Equal(object a, object b)
		{
			return false;
		}

		public static bool NotEqual(object a, object b)
		{
			return false;
		}

		public static bool GreaterThan(object a, object b)
		{
			return false;
		}

		public static bool LessThan(object a, object b)
		{
			return false;
		}

		public static bool GreaterThanOrEqual(object a, object b)
		{
			return false;
		}

		public static bool LessThanOrEqual(object a, object b)
		{
			return false;
		}

		public static object LeftShift(object a, object b)
		{
			return null;
		}

		public static object RightShift(object a, object b)
		{
			return null;
		}
	}
}
