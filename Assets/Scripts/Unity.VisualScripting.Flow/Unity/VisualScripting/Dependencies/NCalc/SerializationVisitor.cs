using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class SerializationVisitor : LogicalExpressionVisitor
	{
		private readonly NumberFormatInfo _numberFormatInfo;

		public StringBuilder Result
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

		public override void Visit(IdentifierExpression identifier)
		{
		}

		protected void EncapsulateNoValue(LogicalExpression expression)
		{
		}
	}
}
