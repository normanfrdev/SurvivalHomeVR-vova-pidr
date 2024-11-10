using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting.FullSerializer
{
	public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve>
	{
		protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public AnimationCurve_DirectConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
