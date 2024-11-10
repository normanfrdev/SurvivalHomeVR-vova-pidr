using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	public sealed class VariableDeclarationCollection : KeyedCollection<string, VariableDeclaration>, IKeyedCollection<string, VariableDeclaration>, ICollection<VariableDeclaration>, IEnumerable<VariableDeclaration>, IEnumerable
	{
		protected override string GetKeyForItem(VariableDeclaration item)
		{
			return null;
		}

		public void EditorRename(VariableDeclaration item, string newName)
		{
		}

		public new bool TryGetValue(string key, out VariableDeclaration value)
		{
			value = null;
			return false;
		}

		public VariableDeclarationCollection()
		{
			((KeyedCollection<TKey, TItem>)(object)this)._002Ector();
		}

		VariableDeclaration IKeyedCollection<string, VariableDeclaration>.get_Item(string key)
		{
			return null;
		}

		bool IKeyedCollection<string, VariableDeclaration>.Contains(string key)
		{
			return false;
		}

		bool IKeyedCollection<string, VariableDeclaration>.Remove(string key)
		{
			return false;
		}
	}
}
