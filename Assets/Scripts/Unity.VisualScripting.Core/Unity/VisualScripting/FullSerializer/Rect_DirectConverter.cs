using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting.FullSerializer
{
	public class Rect_DirectConverter : fsDirectConverter<Rect>
	{
		protected override fsResult DoSerialize(Rect model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Rect model)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public Rect_DirectConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
