namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public struct ComputeBufferDesc
	{
		public int count;

		public int stride;

		public ComputeBufferType type;

		public string name;

		public ComputeBufferDesc(int count, int stride)
		{
		}

		public ComputeBufferDesc(int count, int stride, ComputeBufferType type)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
