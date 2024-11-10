using System;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Unity.VisualScripting
{
	public class RayConverter : fsDirectConverter<Ray>
	{
		protected override fsResult DoSerialize(Ray model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray model)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public RayConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
