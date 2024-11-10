using System;
using System.Collections;
using System.Collections.Generic;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	public sealed class VariableDeclarations : IEnumerable<VariableDeclaration>, IEnumerable, ISpecifiesCloner
	{
		public VariableKind Kind;

		[Serialize]
		[InspectorWide(true)]
		private VariableDeclarationCollection collection;

		internal Action OnVariableChanged;

		public object this[[InspectorVariableName(ActionDirection.Any)] string variable]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		ICloner ISpecifiesCloner.cloner => null;

		public void Set([InspectorVariableName(ActionDirection.Set)] string variable, object value)
		{
		}

		public object Get([InspectorVariableName(ActionDirection.Get)] string variable)
		{
			return null;
		}

		public T Get<T>([InspectorVariableName(ActionDirection.Get)] string variable)
		{
			return default(T);
		}

		public object Get([InspectorVariableName(ActionDirection.Get)] string variable, Type expectedType)
		{
			return null;
		}

		public void Clear()
		{
		}

		public bool IsDefined([InspectorVariableName(ActionDirection.Any)] string variable)
		{
			return false;
		}

		public VariableDeclaration GetDeclaration(string variable)
		{
			return null;
		}

		public IEnumerator<VariableDeclaration> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
