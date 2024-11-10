using System;
using System.Runtime.InteropServices;

namespace UnityEngine.InputSystem.Utilities
{
	[StructLayout(LayoutKind.Explicit)]
	public struct PrimitiveValue : IEquatable<PrimitiveValue>, IConvertible
	{
		[FieldOffset(0)]
		private TypeCode m_Type;

		[FieldOffset(4)]
		private bool m_BoolValue;

		[FieldOffset(4)]
		private char m_CharValue;

		[FieldOffset(4)]
		private byte m_ByteValue;

		[FieldOffset(4)]
		private sbyte m_SByteValue;

		[FieldOffset(4)]
		private short m_ShortValue;

		[FieldOffset(4)]
		private ushort m_UShortValue;

		[FieldOffset(4)]
		private int m_IntValue;

		[FieldOffset(4)]
		private uint m_UIntValue;

		[FieldOffset(4)]
		private long m_LongValue;

		[FieldOffset(4)]
		private ulong m_ULongValue;

		[FieldOffset(4)]
		private float m_FloatValue;

		[FieldOffset(4)]
		private double m_DoubleValue;

		internal unsafe byte* valuePtr => (byte*)unchecked((nint)null);

		public TypeCode type => default(TypeCode);

		public bool isEmpty => false;

		public PrimitiveValue(bool value)
		{
		}

		public PrimitiveValue(char value)
		{
		}

		public PrimitiveValue(byte value)
		{
		}

		public PrimitiveValue(sbyte value)
		{
		}

		public PrimitiveValue(short value)
		{
		}

		public PrimitiveValue(ushort value)
		{
		}

		public PrimitiveValue(int value)
		{
		}

		public PrimitiveValue(uint value)
		{
		}

		public PrimitiveValue(long value)
		{
		}

		public PrimitiveValue(ulong value)
		{
		}

		public PrimitiveValue(float value)
		{
		}

		public PrimitiveValue(double value)
		{
		}

		public PrimitiveValue ConvertTo(TypeCode type)
		{
			return default(PrimitiveValue);
		}

		public bool Equals(PrimitiveValue other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public static bool operator ==(PrimitiveValue left, PrimitiveValue right)
		{
			return false;
		}

		public static bool operator !=(PrimitiveValue left, PrimitiveValue right)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static PrimitiveValue FromString(string value)
		{
			return default(PrimitiveValue);
		}

		public TypeCode GetTypeCode()
		{
			return default(TypeCode);
		}

		public bool ToBoolean(IFormatProvider provider = null)
		{
			return false;
		}

		public byte ToByte(IFormatProvider provider = null)
		{
			return 0;
		}

		public char ToChar(IFormatProvider provider = null)
		{
			return '\0';
		}

		public DateTime ToDateTime(IFormatProvider provider = null)
		{
			return default(DateTime);
		}

		public decimal ToDecimal(IFormatProvider provider = null)
		{
			return default(decimal);
		}

		public double ToDouble(IFormatProvider provider = null)
		{
			return 0.0;
		}

		public short ToInt16(IFormatProvider provider = null)
		{
			return 0;
		}

		public int ToInt32(IFormatProvider provider = null)
		{
			return 0;
		}

		public long ToInt64(IFormatProvider provider = null)
		{
			return 0L;
		}

		public sbyte ToSByte(IFormatProvider provider = null)
		{
			return 0;
		}

		public float ToSingle(IFormatProvider provider = null)
		{
			return 0f;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public object ToType(Type conversionType, IFormatProvider provider)
		{
			return null;
		}

		public ushort ToUInt16(IFormatProvider provider = null)
		{
			return 0;
		}

		public uint ToUInt32(IFormatProvider provider = null)
		{
			return 0u;
		}

		public ulong ToUInt64(IFormatProvider provider = null)
		{
			return 0uL;
		}

		public object ToObject()
		{
			return null;
		}

		public static PrimitiveValue From<TValue>(TValue value) where TValue : struct
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromObject(object value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(bool value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(char value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(byte value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(sbyte value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(short value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(ushort value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(int value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(uint value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(long value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(ulong value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(float value)
		{
			return default(PrimitiveValue);
		}

		public static implicit operator PrimitiveValue(double value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromBoolean(bool value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromChar(char value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromByte(byte value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromSByte(sbyte value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromInt16(short value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromUInt16(ushort value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromInt32(int value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromUInt32(uint value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromInt64(long value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromUInt64(ulong value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromSingle(float value)
		{
			return default(PrimitiveValue);
		}

		public static PrimitiveValue FromDouble(double value)
		{
			return default(PrimitiveValue);
		}
	}
}
