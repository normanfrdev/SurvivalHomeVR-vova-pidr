using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.CoreUtils
{
	public class CachedComponentFilter<TFilterType, TRootType> : IDisposable where TFilterType : class where TRootType : Component
	{
		private readonly List<TFilterType> m_MasterComponentStorage;

		private static readonly List<TFilterType> k_TempComponentList;

		private static readonly List<IComponentHost<TFilterType>> k_TempHostComponentList;

		private bool m_DisposedValue;

		public CachedComponentFilter(TRootType componentRoot, CachedSearchType cachedSearchType = CachedSearchType.Children | CachedSearchType.Self, bool includeDisabled = true)
		{
		}

		public CachedComponentFilter(TFilterType[] componentList, bool includeDisabled = true)
		{
		}

		public void StoreMatchingComponents<TChildType>(List<TChildType> outputList) where TChildType : class, TFilterType
		{
		}

		public TChildType[] GetMatchingComponents<TChildType>() where TChildType : class, TFilterType
		{
			return null;
		}

		private void FilteredCopyToMaster(bool includeDisabled)
		{
		}

		private void FilteredCopyToMaster(bool includeDisabled, TRootType requiredRoot)
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}
	}
}
