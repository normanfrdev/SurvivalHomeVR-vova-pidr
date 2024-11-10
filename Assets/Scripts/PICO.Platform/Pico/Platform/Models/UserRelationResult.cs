using System;
using System.Collections.Generic;

namespace Pico.Platform.Models
{
	public class UserRelationResult : Dictionary<string, UserRelationType>
	{
		public UserRelationResult(IntPtr o)
		{
			((Dictionary<TKey, TValue>)(object)this)._002Ector();
		}
	}
}
