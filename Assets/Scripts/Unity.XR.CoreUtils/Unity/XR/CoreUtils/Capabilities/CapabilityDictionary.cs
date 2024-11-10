using System;
using Unity.XR.CoreUtils.Collections;

namespace Unity.XR.CoreUtils.Capabilities
{
	[Serializable]
	public sealed class CapabilityDictionary : SerializableDictionary<string, bool>
	{
		public void ForceSerialize()
		{
		}

		public override void OnBeforeSerialize()
		{
		}

		public CapabilityDictionary()
		{
			((SerializableDictionary<, >)(object)this)._002Ector();
		}
	}
}
