namespace UnityEngine.Rendering.Universal
{
	internal struct IntPoint
	{
		public long N;

		public long X;

		public long Y;

		public long D;

		public double NX;

		public double NY;

		public IntPoint(long X, long Y)
		{
		}

		public IntPoint(double x, double y)
		{
		}

		public IntPoint(IntPoint pt)
		{
		}

		public static bool operator ==(IntPoint a, IntPoint b)
		{
			return false;
		}

		public static bool operator !=(IntPoint a, IntPoint b)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
