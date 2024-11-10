using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class RewriteRuleNodeStream : RewriteRuleElementStream<object>
	{
		public RewriteRuleNodeStream(ITreeAdaptor adaptor, string elementDescription)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public RewriteRuleNodeStream(ITreeAdaptor adaptor, string elementDescription, object oneElement)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public RewriteRuleNodeStream(ITreeAdaptor adaptor, string elementDescription, IList<object> elements)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		[Obsolete("This constructor is for internal use only and might be phased out soon. Use instead the one with IList<T>.")]
		public RewriteRuleNodeStream(ITreeAdaptor adaptor, string elementDescription, IList elements)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public object NextNode()
		{
			return null;
		}

		protected override object ToTree(object el)
		{
			return null;
		}
	}
}
