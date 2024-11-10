using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public abstract class OperatorHandler
	{
		public string name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string verb
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string symbol
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string customMethodName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected OperatorHandler(string name, string verb, string symbol, string customMethodName)
		{
		}
	}
}
