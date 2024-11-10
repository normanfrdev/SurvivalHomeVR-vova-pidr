using System;

namespace Pico.Platform.Models
{
	public class RoomList : MessageArray<Room>
	{
		public readonly int TotalCount;

		public int CurIndex;

		public int PageSize;

		public RoomList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
