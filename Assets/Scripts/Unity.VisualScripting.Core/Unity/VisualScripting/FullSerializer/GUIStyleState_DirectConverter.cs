using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting.FullSerializer
{
	public class GUIStyleState_DirectConverter : fsDirectConverter<GUIStyleState>
	{
		protected override fsResult DoSerialize(GUIStyleState model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyleState model)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public GUIStyleState_DirectConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
