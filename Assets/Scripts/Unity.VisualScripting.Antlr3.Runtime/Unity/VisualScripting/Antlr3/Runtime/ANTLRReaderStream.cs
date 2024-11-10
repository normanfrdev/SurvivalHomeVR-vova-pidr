using System.IO;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class ANTLRReaderStream : ANTLRStringStream
	{
		public static readonly int READ_BUFFER_SIZE;

		public static readonly int INITIAL_BUFFER_SIZE;

		protected ANTLRReaderStream()
		{
		}

		public ANTLRReaderStream(TextReader reader)
		{
		}

		public ANTLRReaderStream(TextReader reader, int size)
		{
		}

		public ANTLRReaderStream(TextReader reader, int size, int readChunkSize)
		{
		}

		public virtual void Load(TextReader reader, int size, int readChunkSize)
		{
		}
	}
}
