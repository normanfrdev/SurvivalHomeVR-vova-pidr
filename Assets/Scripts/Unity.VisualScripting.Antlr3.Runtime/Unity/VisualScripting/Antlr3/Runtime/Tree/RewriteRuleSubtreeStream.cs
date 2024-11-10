using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public class RewriteRuleSubtreeStream : RewriteRuleElementStream<object>
	{
		private delegate object ProcessHandler(object o);

		public RewriteRuleSubtreeStream(ITreeAdaptor adaptor, string elementDescription)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public RewriteRuleSubtreeStream(ITreeAdaptor adaptor, string elementDescription, object oneElement)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public RewriteRuleSubtreeStream(ITreeAdaptor adaptor, string elementDescription, IList<object> elements)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		[Obsolete("This constructor is for internal use only and might be phased out soon. Use instead the one with IList<T>.")]
		public RewriteRuleSubtreeStream(ITreeAdaptor adaptor, string elementDescription, IList elements)
		{
			((RewriteRuleElementStream<>)(object)this)._002Ector((ITreeAdaptor)null, (string)null);
		}

		public object NextNode()
		{
			return null;
		}

		private object FetchObject(ProcessHandler ph)
		{
			return null;
		}

		private bool RequiresDuplication()
		{
			return false;
		}

		public override object NextTree()
		{
			return null;
		}

		private object Dup(object el)
		{
			return null;
		}
	}
}
