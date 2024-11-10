using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting.FullSerializer
{
	public class Keyframe_DirectConverter : fsDirectConverter<Keyframe>
	{
		protected override fsResult DoSerialize(Keyframe model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Keyframe model)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public Keyframe_DirectConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
