using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class FunctionExpression : LogicalExpression
	{
		public IdentifierExpression Identifier
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

		public LogicalExpression[] Expressions
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

		public FunctionExpression(IdentifierExpression identifier, LogicalExpression[] expressions)
		{
		}

		public override void Accept(LogicalExpressionVisitor visitor)
		{
		}
	}
}
