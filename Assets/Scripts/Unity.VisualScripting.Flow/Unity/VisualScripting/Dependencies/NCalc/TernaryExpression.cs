using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class TernaryExpression : LogicalExpression
	{
		public LogicalExpression LeftExpression
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

		public LogicalExpression MiddleExpression
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

		public LogicalExpression RightExpression
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

		public TernaryExpression(LogicalExpression leftExpression, LogicalExpression middleExpression, LogicalExpression rightExpression)
		{
		}

		public override void Accept(LogicalExpressionVisitor visitor)
		{
		}
	}
}
