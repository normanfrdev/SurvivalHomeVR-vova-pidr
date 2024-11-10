using System.Collections.ObjectModel;

namespace Unity.VisualScripting
{
	public class ProfiledSegmentCollection : KeyedCollection<string, ProfiledSegment>
	{
		protected override string GetKeyForItem(ProfiledSegment item)
		{
			return null;
		}

		public ProfiledSegmentCollection()
		{
			((KeyedCollection<TKey, TItem>)(object)this)._002Ector();
		}
	}
}
