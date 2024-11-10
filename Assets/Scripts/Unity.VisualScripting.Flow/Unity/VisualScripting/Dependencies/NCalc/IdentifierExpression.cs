using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class IdentifierExpression : LogicalExpression
	{
		public string Name
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

		public IdentifierExpression(string name)
		{
		}

		public override void Accept(LogicalExpressionVisitor visitor)
		{
		}
	}
}
