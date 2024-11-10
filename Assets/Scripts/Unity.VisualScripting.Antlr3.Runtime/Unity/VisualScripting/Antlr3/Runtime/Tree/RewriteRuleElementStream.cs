using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting.Antlr3.Runtime.Tree
{
	public abstract class RewriteRuleElementStream<T>
	{
		protected int cursor;

		protected T singleElement;

		protected IList<T> elements;

		protected bool dirty;

		protected string elementDescription;

		protected ITreeAdaptor adaptor;

		public int Count => 0;

		public string Description => null;

		public RewriteRuleElementStream(ITreeAdaptor adaptor, string elementDescription)
		{
		}

		public RewriteRuleElementStream(ITreeAdaptor adaptor, string elementDescription, T oneElement)
		{
		}

		public RewriteRuleElementStream(ITreeAdaptor adaptor, string elementDescription, IList<T> elements)
		{
		}

		[Obsolete("This constructor is for internal use only and might be phased out soon. Use instead the one with IList<T>.")]
		public RewriteRuleElementStream(ITreeAdaptor adaptor, string elementDescription, IList elements)
		{
		}

		public void Add(T el)
		{
		}

		public virtual void Reset()
		{
		}

		public bool HasNext()
		{
			return false;
		}

		public virtual object NextTree()
		{
			return null;
		}

		protected object _Next()
		{
			return null;
		}

		protected virtual object ToTree(T el)
		{
			return null;
		}

		[Obsolete("Please use property Count instead.")]
		public int Size()
		{
			return 0;
		}
	}
}
