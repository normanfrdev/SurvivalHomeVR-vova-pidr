using System;

namespace Pico.Platform.Models
{
	public class ChallengeList : MessageArray<Challenge>
	{
		public readonly ulong TotalCount;

		public ChallengeList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
