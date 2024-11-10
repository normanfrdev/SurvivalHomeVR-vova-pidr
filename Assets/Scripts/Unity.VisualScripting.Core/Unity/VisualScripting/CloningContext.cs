using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	public sealed class CloningContext : IPoolable, IDisposable
	{
		private bool disposed;

		public Dictionary<object, object> clonings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ICloner fallbackCloner
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

		public bool tryPreserveInstances
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		void IPoolable.New()
		{
		}

		void IPoolable.Free()
		{
		}

		public void Dispose()
		{
		}

		public static CloningContext New(ICloner fallbackCloner, bool tryPreserveInstances)
		{
			return null;
		}
	}
}
