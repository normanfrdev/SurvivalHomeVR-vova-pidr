using System;

namespace Pico.Platform.Models
{
	public class KVPair
	{
		private IntPtr Handle;

		private bool destroyable;

		public KVPair()
		{
		}

		public KVPair(IntPtr o)
		{
		}

		public void SetIntValue(int value)
		{
		}

		public void SetStringValue(string value)
		{
		}

		public void SetDoubleValue(double value)
		{
		}

		public int GetIntValue()
		{
			return 0;
		}

		public string GetStringValue()
		{
			return null;
		}

		public double GetDoubleValue()
		{
			return 0.0;
		}

		public void SetKey(string key)
		{
		}

		public string GetKey()
		{
			return null;
		}

		public KVPairType GetValueType()
		{
			return default(KVPairType);
		}

		~KVPair()
		{
		}
	}
}
