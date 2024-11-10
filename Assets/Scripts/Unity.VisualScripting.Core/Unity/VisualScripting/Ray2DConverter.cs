using System;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace Unity.VisualScripting
{
	public class Ray2DConverter : fsDirectConverter<Ray2D>
	{
		protected override fsResult DoSerialize(Ray2D model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Ray2D model)
		{
			return default(fsResult);
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public Ray2DConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
