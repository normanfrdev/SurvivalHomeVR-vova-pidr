using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class BinaryExpression : LogicalExpression
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

		public BinaryExpressionType Type
		{
			[CompilerGenerated]
			get
			{
				return default(BinaryExpressionType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BinaryExpression(BinaryExpressionType type, LogicalExpression leftExpression, LogicalExpression rightExpression)
		{
		}

		public override void Accept(LogicalExpressionVisitor visitor)
		{
		}
	}
}
