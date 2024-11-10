using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class ValueExpression : LogicalExpression
	{
		public object Value
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

		public ValueType Type
		{
			[CompilerGenerated]
			get
			{
				return default(ValueType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ValueExpression(object value, ValueType type)
		{
		}

		public ValueExpression(object value)
		{
		}

		public ValueExpression(string value)
		{
		}

		public ValueExpression(int value)
		{
		}

		public ValueExpression(float value)
		{
		}

		public ValueExpression(DateTime value)
		{
		}

		public ValueExpression(bool value)
		{
		}

		public override void Accept(LogicalExpressionVisitor visitor)
		{
		}
	}
}
