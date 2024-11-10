using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class ParameterArgs : EventArgs
	{
		private object _result;

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
	}
}
