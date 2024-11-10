using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Unity.Burst.Intrinsics
{
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerTypeProxy(typeof(V64DebugView))]
	public struct v64
	{
		[FieldOffset(0)]
		public byte Byte0;

		[FieldOffset(1)]
		public byte Byte1;

		[FieldOffset(2)]
		public byte Byte2;

		[FieldOffset(3)]
		public byte Byte3;

		[FieldOffset(4)]
		public byte Byte4;

		[FieldOffset(5)]
		public byte Byte5;

		[FieldOffset(6)]
		public byte Byte6;

		[FieldOffset(7)]
		public byte Byte7;

		[FieldOffset(0)]
		public sbyte SByte0;

		[FieldOffset(1)]
		public sbyte SByte1;

		[FieldOffset(2)]
		public sbyte SByte2;

		[FieldOffset(3)]
		public sbyte SByte3;

		[FieldOffset(4)]
		public sbyte SByte4;

		[FieldOffset(5)]
		public sbyte SByte5;

		[FieldOffset(6)]
		public sbyte SByte6;

		[FieldOffset(7)]
		public sbyte SByte7;

		[FieldOffset(0)]
		public ushort UShort0;

		[FieldOffset(2)]
		public ushort UShort1;

		[FieldOffset(4)]
		public ushort UShort2;

		[FieldOffset(6)]
		public ushort UShort3;

		[FieldOffset(0)]
		public short SShort0;

		[FieldOffset(2)]
		public short SShort1;

		[FieldOffset(4)]
		public short SShort2;

		[FieldOffset(6)]
		public short SShort3;

		[FieldOffset(0)]
		public uint UInt0;

		[FieldOffset(4)]
		public uint UInt1;

		[FieldOffset(0)]
		public int SInt0;

		[FieldOffset(4)]
		public int SInt1;

		[FieldOffset(0)]
		public ulong ULong0;

		[FieldOffset(0)]
		public long SLong0;

		[FieldOffset(0)]
		public float Float0;

		[FieldOffset(4)]
		public float Float1;

		[FieldOffset(0)]
		public double Double0;

		public v64(byte b)
		{
		}

		public v64(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h)
		{
		}

		public v64(sbyte b)
		{
		}

		public v64(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h)
		{
		}

		public v64(short v)
		{
		}

		public v64(short a, short b, short c, short d)
		{
		}

		public v64(ushort v)
		{
		}

		public v64(ushort a, ushort b, ushort c, ushort d)
		{
		}

		public v64(int v)
		{
		}

		public v64(int a, int b)
		{
		}

		public v64(uint v)
		{
		}

		public v64(uint a, uint b)
		{
		}

		public v64(float f)
		{
		}

		public v64(float a, float b)
		{
		}

		public v64(double a)
		{
		}

		public v64(long a)
		{
		}

		public v64(ulong a)
		{
		}
	}
}
