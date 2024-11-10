using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class RewriteRuleTokenStream : RewriteRuleElementStream<IToken>
	{
		public RewriteRuleTokenStream(ITreeAdaptor adaptor, string elementDescription)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public RewriteRuleTokenStream(ITreeAdaptor adaptor, string elementDescription, IToken oneElement)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public RewriteRuleTokenStream(ITreeAdaptor adaptor, string elementDescription, IList<IToken> elements)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		[Obsolete("This constructor is for internal use only and might be phased out soon. Use instead the one with IList<T>.")]
		public RewriteRuleTokenStream(ITreeAdaptor adaptor, string elementDescription, IList elements)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public object NextNode()
		{
			return null;
		}

		public IToken NextToken()
		{
			return null;
		}

		protected override object ToTree(IToken el)
		{
			return null;
		}
	}
}
