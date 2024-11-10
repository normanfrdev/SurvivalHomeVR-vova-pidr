using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting.FullSerializer
{
	public class Bounds_DirectConverter : fsDirectConverter<Bounds>
	{
		protected override fsResult DoSerialize(Bounds model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Bounds model)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public Bounds_DirectConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
