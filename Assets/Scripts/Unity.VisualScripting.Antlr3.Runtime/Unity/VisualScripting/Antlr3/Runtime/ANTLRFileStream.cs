using System.IO;
using System.Text;

namespace Unity.VisualScripting.Antlr3.Runtime
{
	public class ANTLRFileStream : ANTLRStringStream
	{
		protected string fileName;

		public override string SourceName => null;

		protected ANTLRFileStream()
		{
		}

		public ANTLRFileStream(string fileName)
		{
		}

		public ANTLRFileStream(string fileName, Encoding encoding)
		{
		}

		public virtual void Load(string fileName, Encoding encoding)
		{
		}

		private long GetFileLength(FileInfo file)
		{
			return 0L;
		}
	}
}
