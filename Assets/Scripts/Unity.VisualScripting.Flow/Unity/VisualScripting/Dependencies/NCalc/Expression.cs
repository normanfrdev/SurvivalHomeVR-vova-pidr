using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Unity.VisualScripting.Dependencies.NCalc
{
	public class Expression
	{
		protected readonly string OriginalExpression;

		protected Dictionary<string, IEnumerator> ParameterEnumerators;

		private Dictionary<string, object> _parameters;

		private static bool _cacheEnabled;

		private static Dictionary<string, WeakReference> _compiledExpressions;

		private static readonly ReaderWriterLock Rwl;

		public EvaluateOptions Options
		{
			[CompilerGenerated]
			get
			{
				return default(EvaluateOptions);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LogicalExpression ParsedExpression
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Dictionary<string, object> Parameters
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool CacheEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event EvaluateFunctionHandler EvaluateFunction
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EvaluateParameterHandler EvaluateParameter
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private Expression()
		{
		}

		public Expression(string expression, EvaluateOptions options = EvaluateOptions.None)
		{
		}

		public Expression(LogicalExpression expression, EvaluateOptions options = EvaluateOptions.None)
		{
		}

		public void UpdateUnityTimeParameters()
		{
		}

		public bool HasErrors()
		{
			return false;
		}

		public object Evaluate(Flow flow)
		{
			return null;
		}

		public static LogicalExpression Compile(string expression, bool noCache)
		{
			return null;
		}

		private static void CleanCache()
		{
		}
	}
}
