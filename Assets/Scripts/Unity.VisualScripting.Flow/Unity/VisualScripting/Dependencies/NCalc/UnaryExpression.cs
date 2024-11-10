using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class UnaryExpression : LogicalExpression
	{
		public LogicalExpression Expression
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

		public UnaryExpressionType Type
		{
			[CompilerGenerated]
			get
			{
				return default(UnaryExpressionType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public UnaryExpression(UnaryExpressionType type, LogicalExpression expression)
		{
		}

		public override void Accept(LogicalExpressionVisitor visitor)
		{
		}
	}
}
