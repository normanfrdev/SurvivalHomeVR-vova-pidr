using System;

namespace Unity.VisualScripting
{
	public abstract class Cloner<T> : ICloner
	{
		public abstract bool Handles(Type type);

		void ICloner.BeforeClone(Type type, object original)
		{
		}

		public virtual void BeforeClone(Type type, T original)
		{
		}

		object ICloner.ConstructClone(Type type, object original)
		{
			return null;
		}

		public virtual T ConstructClone(Type type, T original)
		{
			return default(T);
		}

		void ICloner.FillClone(Type type, ref object clone, object original, CloningContext context)
		{
		}

		public virtual void FillClone(Type type, ref T clone, T original, CloningContext context)
		{
		}

		void ICloner.AfterClone(Type type, object clone)
		{
		}

		public virtual void AfterClone(Type type, T clone)
		{
		}
	}
}
