using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class FunctionArgs : EventArgs
	{
		private object _result;

		private Expression[] _parameters;

		public object Result
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool HasResult
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

		public Expression[] Parameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object[] EvaluateParameters(Flow flow)
		{
			return null;
		}
	}
}
