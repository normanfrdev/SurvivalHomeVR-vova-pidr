using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Unity.Burst.Intrinsics
{
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerTypeProxy(typeof(V128DebugView))]
	public struct v128
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

		[FieldOffset(8)]
		public byte Byte8;

		[FieldOffset(9)]
		public byte Byte9;

		[FieldOffset(10)]
		public byte Byte10;

		[FieldOffset(11)]
		public byte Byte11;

		[FieldOffset(12)]
		public byte Byte12;

		[FieldOffset(13)]
		public byte Byte13;

		[FieldOffset(14)]
		public byte Byte14;

		[FieldOffset(15)]
		public byte Byte15;

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

		[FieldOffset(8)]
		public sbyte SByte8;

		[FieldOffset(9)]
		public sbyte SByte9;

		[FieldOffset(10)]
		public sbyte SByte10;

		[FieldOffset(11)]
		public sbyte SByte11;

		[FieldOffset(12)]
		public sbyte SByte12;

		[FieldOffset(13)]
		public sbyte SByte13;

		[FieldOffset(14)]
		public sbyte SByte14;

		[FieldOffset(15)]
		public sbyte SByte15;

		[FieldOffset(0)]
		public ushort UShort0;

		[FieldOffset(2)]
		public ushort UShort1;

		[FieldOffset(4)]
		public ushort UShort2;

		[FieldOffset(6)]
		public ushort UShort3;

		[FieldOffset(8)]
		public ushort UShort4;

		[FieldOffset(10)]
		public ushort UShort5;

		[FieldOffset(12)]
		public ushort UShort6;

		[FieldOffset(14)]
		public ushort UShort7;

		[FieldOffset(0)]
		public short SShort0;

		[FieldOffset(2)]
		public short SShort1;

		[FieldOffset(4)]
		public short SShort2;

		[FieldOffset(6)]
		public short SShort3;

		[FieldOffset(8)]
		public short SShort4;

		[FieldOffset(10)]
		public short SShort5;

		[FieldOffset(12)]
		public short SShort6;

		[FieldOffset(14)]
		public short SShort7;

		[FieldOffset(0)]
		public uint UInt0;

		[FieldOffset(4)]
		public uint UInt1;

		[FieldOffset(8)]
		public uint UInt2;

		[FieldOffset(12)]
		public uint UInt3;

		[FieldOffset(0)]
		public int SInt0;

		[FieldOffset(4)]
		public int SInt1;

		[FieldOffset(8)]
		public int SInt2;

		[FieldOffset(12)]
		public int SInt3;

		[FieldOffset(0)]
		public ulong ULong0;

		[FieldOffset(8)]
		public ulong ULong1;

		[FieldOffset(0)]
		public long SLong0;

		[FieldOffset(8)]
		public long SLong1;

		[FieldOffset(0)]
		public float Float0;

		[FieldOffset(4)]
		public float Float1;

		[FieldOffset(8)]
		public float Float2;

		[FieldOffset(12)]
		public float Float3;

		[FieldOffset(0)]
		public double Double0;

		[FieldOffset(8)]
		public double Double1;

		[FieldOffset(0)]
		public v64 Lo64;

		[FieldOffset(8)]
		public v64 Hi64;

		public v128(byte b)
		{
		}

		public v128(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k, byte l, byte m, byte n, byte o, byte p)
		{
		}

		public v128(sbyte b)
		{
		}

		public v128(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h, sbyte i, sbyte j, sbyte k, sbyte l, sbyte m, sbyte n, sbyte o, sbyte p)
		{
		}

		public v128(short v)
		{
		}

		public v128(short a, short b, short c, short d, short e, short f, short g, short h)
		{
		}

		public v128(ushort v)
		{
		}

		public v128(ushort a, ushort b, ushort c, ushort d, ushort e, ushort f, ushort g, ushort h)
		{
		}

		public v128(int v)
		{
		}

		public v128(int a, int b, int c, int d)
		{
		}

		public v128(uint v)
		{
		}

		public v128(uint a, uint b, uint c, uint d)
		{
		}

		public v128(float f)
		{
		}

		public v128(float a, float b, float c, float d)
		{
		}

		public v128(double f)
		{
		}

		public v128(double a, double b)
		{
		}

		public v128(long f)
		{
		}

		public v128(long a, long b)
		{
		}

		public v128(ulong f)
		{
		}

		public v128(ulong a, ulong b)
		{
		}

		public v128(v64 lo, v64 hi)
		{
		}
	}
}
