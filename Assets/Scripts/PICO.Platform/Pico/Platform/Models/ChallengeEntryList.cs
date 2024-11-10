using System;

namespace Pico.Platform.Models
{
	public class ChallengeEntryList : MessageArray<ChallengeEntry>
	{
		public readonly ulong TotalCount;

		public ChallengeEntryList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
