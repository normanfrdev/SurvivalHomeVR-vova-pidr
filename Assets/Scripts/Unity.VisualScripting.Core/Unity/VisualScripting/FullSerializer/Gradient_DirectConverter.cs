using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.VisualScripting.FullSerializer
{
	public class Gradient_DirectConverter : fsDirectConverter<Gradient>
	{
		protected override fsResult DoSerialize(Gradient model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref Gradient model)
		{
			return default(fsResult);
		}

		private static void LogWarning(string phase)
		{
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public Gradient_DirectConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
