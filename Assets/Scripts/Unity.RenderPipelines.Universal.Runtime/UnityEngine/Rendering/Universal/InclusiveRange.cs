namespace UnityEngine.Rendering.Universal
{
	internal struct InclusiveRange
	{
		public short start;

		public short end;

		public bool isEmpty => false;

		public static InclusiveRange empty => default(InclusiveRange);

		public InclusiveRange(short startEnd)
		{
		}

		public InclusiveRange(short start, short end)
		{
		}

		public void Expand(short index)
		{
		}

		public void Clamp(short min, short max)
		{
		}

		public bool Contains(short index)
		{
			return false;
		}

		public static InclusiveRange Merge(InclusiveRange a, InclusiveRange b)
		{
			return default(InclusiveRange);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
