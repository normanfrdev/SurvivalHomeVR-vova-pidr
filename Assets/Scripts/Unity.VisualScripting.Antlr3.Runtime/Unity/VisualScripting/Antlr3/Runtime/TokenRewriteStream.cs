using System;
using System.Collections;
using System.Text;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class TokenRewriteStream : CommonTokenStream
	{
		private class RewriteOpComparer : IComparer
		{
			public virtual int Compare(object o1, object o2)
			{
				return 0;
			}
		}

		protected internal class RewriteOperation
		{
			protected internal int instructionIndex;

			protected internal int index;

			protected internal object text;

			protected internal TokenRewriteStream parent;

			protected internal RewriteOperation(int index, object text, TokenRewriteStream parent)
			{
			}

			public virtual int Execute(StringBuilder buf)
			{
				return 0;
			}

			public override string ToString()
			{
				return null;
			}
		}

		protected internal class InsertBeforeOp : RewriteOperation
		{
			public InsertBeforeOp(int index, object text, TokenRewriteStream parent)
				: base(0, null, null)
			{
			}

			public override int Execute(StringBuilder buf)
			{
				return 0;
			}
		}

		protected internal class ReplaceOp : RewriteOperation
		{
			protected internal int lastIndex;

			public ReplaceOp(int from, int to, object text, TokenRewriteStream parent)
				: base(0, null, null)
			{
			}

			public override int Execute(StringBuilder buf)
			{
				return 0;
			}

			public override string ToString()
			{
				return null;
			}
		}

		protected internal class DeleteOp : ReplaceOp
		{
			public DeleteOp(int from, int to, TokenRewriteStream parent)
				: base(0, 0, null, null)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public const string DEFAULT_PROGRAM_NAME = "default";

		public const int PROGRAM_INIT_SIZE = 100;

		public const int MIN_TOKEN_INDEX = 0;

		protected IDictionary programs;

		protected IDictionary lastRewriteTokenIndexes;

		public TokenRewriteStream()
		{
		}

		public TokenRewriteStream(ITokenSource tokenSource)
		{
		}

		public TokenRewriteStream(ITokenSource tokenSource, int channel)
		{
		}

		protected internal virtual void Init()
		{
		}

		public virtual void Rollback(int instructionIndex)
		{
		}

		public virtual void Rollback(string programName, int instructionIndex)
		{
		}

		public virtual void DeleteProgram()
		{
		}

		public virtual void DeleteProgram(string programName)
		{
		}

		public virtual void InsertAfter(IToken t, object text)
		{
		}

		public virtual void InsertAfter(int index, object text)
		{
		}

		public virtual void InsertAfter(string programName, IToken t, object text)
		{
		}

		public virtual void InsertAfter(string programName, int index, object text)
		{
		}

		public virtual void InsertBefore(IToken t, object text)
		{
		}

		public virtual void InsertBefore(int index, object text)
		{
		}

		public virtual void InsertBefore(string programName, IToken t, object text)
		{
		}

		public virtual void InsertBefore(string programName, int index, object text)
		{
		}

		public virtual void Replace(int index, object text)
		{
		}

		public virtual void Replace(int from, int to, object text)
		{
		}

		public virtual void Replace(IToken indexT, object text)
		{
		}

		public virtual void Replace(IToken from, IToken to, object text)
		{
		}

		public virtual void Replace(string programName, int from, int to, object text)
		{
		}

		public virtual void Replace(string programName, IToken from, IToken to, object text)
		{
		}

		public virtual void Delete(int index)
		{
		}

		public virtual void Delete(int from, int to)
		{
		}

		public virtual void Delete(IToken indexT)
		{
		}

		public virtual void Delete(IToken from, IToken to)
		{
		}

		public virtual void Delete(string programName, int from, int to)
		{
		}

		public virtual void Delete(string programName, IToken from, IToken to)
		{
		}

		public virtual int GetLastRewriteTokenIndex()
		{
			return 0;
		}

		protected virtual int GetLastRewriteTokenIndex(string programName)
		{
			return 0;
		}

		protected virtual void SetLastRewriteTokenIndex(string programName, int i)
		{
		}

		protected virtual IList GetProgram(string name)
		{
			return null;
		}

		private IList InitializeProgram(string name)
		{
			return null;
		}

		public virtual string ToOriginalString()
		{
			return null;
		}

		public virtual string ToOriginalString(int start, int end)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public virtual string ToString(string programName)
		{
			return null;
		}

		public override string ToString(int start, int end)
		{
			return null;
		}

		public virtual string ToString(string programName, int start, int end)
		{
			return null;
		}

		protected IDictionary ReduceToSingleOperationPerIndex(IList rewrites)
		{
			return null;
		}

		protected string CatOpText(object a, object b)
		{
			return null;
		}

		protected IList GetKindOfOps(IList rewrites, Type kind)
		{
			return null;
		}

		protected IList GetKindOfOps(IList rewrites, Type kind, int before)
		{
			return null;
		}

		public virtual string ToDebugString()
		{
			return null;
		}

		public virtual string ToDebugString(int start, int end)
		{
			return null;
		}
	}
}
