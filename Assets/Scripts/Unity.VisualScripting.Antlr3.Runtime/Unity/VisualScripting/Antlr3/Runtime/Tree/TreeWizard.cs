using System.Collections;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class TreeWizard
	{
		public interface ContextVisitor
		{
			void Visit(object t, object parent, int childIndex, IDictionary labels);
		}

		public abstract class Visitor : ContextVisitor
		{
			public void Visit(object t, object parent, int childIndex, IDictionary labels)
			{
			}

			public abstract void Visit(object t);
		}

		private sealed class RecordAllElementsVisitor : Visitor
		{
			private IList list;

			public RecordAllElementsVisitor(IList list)
			{
			}

			public override void Visit(object t)
			{
			}
		}

		private sealed class PatternMatchingContextVisitor : ContextVisitor
		{
			private TreeWizard owner;

			private TreePattern pattern;

			private IList list;

			public PatternMatchingContextVisitor(TreeWizard owner, TreePattern pattern, IList list)
			{
			}

			public void Visit(object t, object parent, int childIndex, IDictionary labels)
			{
			}
		}

		public class TreePattern : CommonTree
		{
			public string label;

			public bool hasTextArg;

			public TreePattern(IToken payload)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private sealed class InvokeVisitorOnPatternMatchContextVisitor : ContextVisitor
		{
			private TreeWizard owner;

			private TreePattern pattern;

			private ContextVisitor visitor;

			private Hashtable labels;

			public InvokeVisitorOnPatternMatchContextVisitor(TreeWizard owner, TreePattern pattern, ContextVisitor visitor)
			{
			}

			public void Visit(object t, object parent, int childIndex, IDictionary unusedlabels)
			{
			}
		}

		public class WildcardTreePattern : TreePattern
		{
			public WildcardTreePattern(IToken payload)
				: base(null)
			{
			}
		}

		public class TreePatternTreeAdaptor : CommonTreeAdaptor
		{
			public override object Create(IToken payload)
			{
				return null;
			}
		}

		protected ITreeAdaptor adaptor;

		protected IDictionary tokenNameToTypeMap;

		public TreeWizard(ITreeAdaptor adaptor)
		{
		}

		public TreeWizard(ITreeAdaptor adaptor, IDictionary tokenNameToTypeMap)
		{
		}

		public TreeWizard(ITreeAdaptor adaptor, string[] tokenNames)
		{
		}

		public TreeWizard(string[] tokenNames)
		{
		}

		public IDictionary ComputeTokenTypes(string[] tokenNames)
		{
			return null;
		}

		public int GetTokenType(string tokenName)
		{
			return 0;
		}

		public IDictionary Index(object t)
		{
			return null;
		}

		protected void _Index(object t, IDictionary m)
		{
		}

		public IList Find(object t, int ttype)
		{
			return null;
		}

		public IList Find(object t, string pattern)
		{
			return null;
		}

		public object FindFirst(object t, int ttype)
		{
			return null;
		}

		public object FindFirst(object t, string pattern)
		{
			return null;
		}

		public void Visit(object t, int ttype, ContextVisitor visitor)
		{
		}

		protected void _Visit(object t, object parent, int childIndex, int ttype, ContextVisitor visitor)
		{
		}

		public void Visit(object t, string pattern, ContextVisitor visitor)
		{
		}

		public bool Parse(object t, string pattern, IDictionary labels)
		{
			return false;
		}

		public bool Parse(object t, string pattern)
		{
			return false;
		}

		protected bool _Parse(object t1, TreePattern t2, IDictionary labels)
		{
			return false;
		}

		public object Create(string pattern)
		{
			return null;
		}

		public static bool Equals(object t1, object t2, ITreeAdaptor adaptor)
		{
			return false;
		}

		public new bool Equals(object t1, object t2)
		{
			return false;
		}

		protected static bool _Equals(object t1, object t2, ITreeAdaptor adaptor)
		{
			return false;
		}
	}
}
