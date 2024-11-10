using System;
using System.Runtime.InteropServices;

namespace Pico.Platform
{
	public class UTF8Marshaller : ICustomMarshaler
	{
		private static UTF8Marshaller marshaler;

		public void CleanUpManagedData(object ManagedObj)
		{
		}

		public void CleanUpNativeData(IntPtr pNativeData)
		{
		}

		public int GetNativeDataSize()
		{
			return 0;
		}

		public IntPtr MarshalManagedToNative(object managedObj)
		{
			return (IntPtr)0;
		}

		public object MarshalNativeToManaged(IntPtr str)
		{
			return null;
		}

		public static ICustomMarshaler GetInstance(string pstrCookie)
		{
			return null;
		}
	}
}
