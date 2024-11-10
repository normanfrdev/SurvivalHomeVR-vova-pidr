using System.Collections.Generic;

namespace Unity.VisualScripting
{
	public class ConnectionCollection<TConnection, TSource, TDestination> : ConnectionCollectionBase<TConnection, TSource, TDestination, List<TConnection>> where TConnection : IConnection<TSource, TDestination>
	{
		public ConnectionCollection()
		{
			((ConnectionCollectionBase<, , , >)(object)this)._002Ector((TCollection)default(_00213));
		}
	}
}
