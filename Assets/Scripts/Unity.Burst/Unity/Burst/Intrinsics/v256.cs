using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Unity.Burst.Intrinsics
{
	[StructLayout(LayoutKind.Explicit)]
	[DebuggerTypeProxy(typeof(V256DebugView))]
	public struct v256
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

		[FieldOffset(16)]
		public byte Byte16;

		[FieldOffset(17)]
		public byte Byte17;

		[FieldOffset(18)]
		public byte Byte18;

		[FieldOffset(19)]
		public byte Byte19;

		[FieldOffset(20)]
		public byte Byte20;

		[FieldOffset(21)]
		public byte Byte21;

		[FieldOffset(22)]
		public byte Byte22;

		[FieldOffset(23)]
		public byte Byte23;

		[FieldOffset(24)]
		public byte Byte24;

		[FieldOffset(25)]
		public byte Byte25;

		[FieldOffset(26)]
		public byte Byte26;

		[FieldOffset(27)]
		public byte Byte27;

		[FieldOffset(28)]
		public byte Byte28;

		[FieldOffset(29)]
		public byte Byte29;

		[FieldOffset(30)]
		public byte Byte30;

		[FieldOffset(31)]
		public byte Byte31;

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

		[FieldOffset(16)]
		public sbyte SByte16;

		[FieldOffset(17)]
		public sbyte SByte17;

		[FieldOffset(18)]
		public sbyte SByte18;

		[FieldOffset(19)]
		public sbyte SByte19;

		[FieldOffset(20)]
		public sbyte SByte20;

		[FieldOffset(21)]
		public sbyte SByte21;

		[FieldOffset(22)]
		public sbyte SByte22;

		[FieldOffset(23)]
		public sbyte SByte23;

		[FieldOffset(24)]
		public sbyte SByte24;

		[FieldOffset(25)]
		public sbyte SByte25;

		[FieldOffset(26)]
		public sbyte SByte26;

		[FieldOffset(27)]
		public sbyte SByte27;

		[FieldOffset(28)]
		public sbyte SByte28;

		[FieldOffset(29)]
		public sbyte SByte29;

		[FieldOffset(30)]
		public sbyte SByte30;

		[FieldOffset(31)]
		public sbyte SByte31;

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

		[FieldOffset(16)]
		public ushort UShort8;

		[FieldOffset(18)]
		public ushort UShort9;

		[FieldOffset(20)]
		public ushort UShort10;

		[FieldOffset(22)]
		public ushort UShort11;

		[FieldOffset(24)]
		public ushort UShort12;

		[FieldOffset(26)]
		public ushort UShort13;

		[FieldOffset(28)]
		public ushort UShort14;

		[FieldOffset(30)]
		public ushort UShort15;

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

		[FieldOffset(16)]
		public short SShort8;

		[FieldOffset(18)]
		public short SShort9;

		[FieldOffset(20)]
		public short SShort10;

		[FieldOffset(22)]
		public short SShort11;

		[FieldOffset(24)]
		public short SShort12;

		[FieldOffset(26)]
		public short SShort13;

		[FieldOffset(28)]
		public short SShort14;

		[FieldOffset(30)]
		public short SShort15;

		[FieldOffset(0)]
		public uint UInt0;

		[FieldOffset(4)]
		public uint UInt1;

		[FieldOffset(8)]
		public uint UInt2;

		[FieldOffset(12)]
		public uint UInt3;

		[FieldOffset(16)]
		public uint UInt4;

		[FieldOffset(20)]
		public uint UInt5;

		[FieldOffset(24)]
		public uint UInt6;

		[FieldOffset(28)]
		public uint UInt7;

		[FieldOffset(0)]
		public int SInt0;

		[FieldOffset(4)]
		public int SInt1;

		[FieldOffset(8)]
		public int SInt2;

		[FieldOffset(12)]
		public int SInt3;

		[FieldOffset(16)]
		public int SInt4;

		[FieldOffset(20)]
		public int SInt5;

		[FieldOffset(24)]
		public int SInt6;

		[FieldOffset(28)]
		public int SInt7;

		[FieldOffset(0)]
		public ulong ULong0;

		[FieldOffset(8)]
		public ulong ULong1;

		[FieldOffset(16)]
		public ulong ULong2;

		[FieldOffset(24)]
		public ulong ULong3;

		[FieldOffset(0)]
		public long SLong0;

		[FieldOffset(8)]
		public long SLong1;

		[FieldOffset(16)]
		public long SLong2;

		[FieldOffset(24)]
		public long SLong3;

		[FieldOffset(0)]
		public float Float0;

		[FieldOffset(4)]
		public float Float1;

		[FieldOffset(8)]
		public float Float2;

		[FieldOffset(12)]
		public float Float3;

		[FieldOffset(16)]
		public float Float4;

		[FieldOffset(20)]
		public float Float5;

		[FieldOffset(24)]
		public float Float6;

		[FieldOffset(28)]
		public float Float7;

		[FieldOffset(0)]
		public double Double0;

		[FieldOffset(8)]
		public double Double1;

		[FieldOffset(16)]
		public double Double2;

		[FieldOffset(24)]
		public double Double3;

		[FieldOffset(0)]
		public v128 Lo128;

		[FieldOffset(16)]
		public v128 Hi128;

		public v256(byte b)
		{
		}

		public v256(byte a, byte b, byte c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k, byte l, byte m, byte n, byte o, byte p, byte q, byte r, byte s, byte t, byte u, byte v, byte w, byte x, byte y, byte z, byte A, byte B, byte C, byte D, byte E, byte F)
		{
		}

		public v256(sbyte b)
		{
		}

		public v256(sbyte a, sbyte b, sbyte c, sbyte d, sbyte e, sbyte f, sbyte g, sbyte h, sbyte i, sbyte j, sbyte k, sbyte l, sbyte m, sbyte n, sbyte o, sbyte p, sbyte q, sbyte r, sbyte s, sbyte t, sbyte u, sbyte v, sbyte w, sbyte x, sbyte y, sbyte z, sbyte A, sbyte B, sbyte C, sbyte D, sbyte E, sbyte F)
		{
		}

		public v256(short v)
		{
		}

		public v256(short a, short b, short c, short d, short e, short f, short g, short h, short i, short j, short k, short l, short m, short n, short o, short p)
		{
		}

		public v256(ushort v)
		{
		}

		public v256(ushort a, ushort b, ushort c, ushort d, ushort e, ushort f, ushort g, ushort h, ushort i, ushort j, ushort k, ushort l, ushort m, ushort n, ushort o, ushort p)
		{
		}

		public v256(int v)
		{
		}

		public v256(int a, int b, int c, int d, int e, int f, int g, int h)
		{
		}

		public v256(uint v)
		{
		}

		public v256(uint a, uint b, uint c, uint d, uint e, uint f, uint g, uint h)
		{
		}

		public v256(float f)
		{
		}

		public v256(float a, float b, float c, float d, float e, float f, float g, float h)
		{
		}

		public v256(double f)
		{
		}

		public v256(double a, double b, double c, double d)
		{
		}

		public v256(long f)
		{
		}

		public v256(long a, long b, long c, long d)
		{
		}

		public v256(ulong f)
		{
		}

		public v256(ulong a, ulong b, ulong c, ulong d)
		{
		}

		public v256(v128 lo, v128 hi)
		{
		}
	}
}
