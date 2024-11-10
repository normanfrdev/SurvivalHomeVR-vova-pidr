using System;

namespace Pico.Platform.Models
{
	public class ApplicationInviteList : MessageArray<ApplicationInvite>
	{
		public ApplicationInviteList(IntPtr a)
		{
			((MessageArray<>)(object)this)._002Ector();
		}
	}
}
