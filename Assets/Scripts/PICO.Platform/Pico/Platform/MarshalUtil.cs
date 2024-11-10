using System;
using System.Text;

namespace Pico.Platform
{
	public static class MarshalUtil
	{
		public static IntPtr StringToPtr(string s)
		{
			return (IntPtr)0;
		}

		public static string PtrToString(IntPtr p)
		{
			return null;
		}

		public static string GetString(Encoding encoding, IntPtr str)
		{
			return null;
		}

		public static byte[] ByteArrayFromNative(IntPtr ptr, uint length)
		{
			return null;
		}

		public static IntPtr ByteArrayToNative(byte[] a)
		{
			return (IntPtr)0;
		}
	}
}
