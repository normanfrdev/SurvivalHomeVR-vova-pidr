using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace LitJson
{
	public class JsonWriter
	{
		private static readonly NumberFormatInfo number_format;

		private WriterContext context;

		private Stack<WriterContext> ctx_stack;

		private bool has_reached_end;

		private char[] hex_seq;

		private int indentation;

		private int indent_value;

		private StringBuilder inst_string_builder;

		private bool pretty_print;

		private bool validate;

		private bool lower_case_properties;

		private TextWriter writer;

		public int IndentValue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool PrettyPrint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TextWriter TextWriter => null;

		public bool Validate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LowerCaseProperties
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		static JsonWriter()
		{
		}

		public JsonWriter()
		{
		}

		public JsonWriter(StringBuilder sb)
		{
		}

		public JsonWriter(TextWriter writer)
		{
		}

		private void DoValidation(Condition cond)
		{
		}

		private void Init()
		{
		}

		private static void IntToHex(int n, char[] hex)
		{
		}

		private void Indent()
		{
		}

		private void Put(string str)
		{
		}

		private void PutNewline()
		{
		}

		private void PutNewline(bool add_comma)
		{
		}

		private void PutString(string str)
		{
		}

		private void Unindent()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public void Reset()
		{
		}

		public void Write(bool boolean)
		{
		}

		public void Write(decimal number)
		{
		}

		public void Write(double number)
		{
		}

		public void Write(float number)
		{
		}

		public void Write(int number)
		{
		}

		public void Write(long number)
		{
		}

		public void Write(string str)
		{
		}

		[CLSCompliant(false)]
		public void Write(ulong number)
		{
		}

		public void WriteArrayEnd()
		{
		}

		public void WriteArrayStart()
		{
		}

		public void WriteObjectEnd()
		{
		}

		public void WriteObjectStart()
		{
		}

		public void WritePropertyName(string property_name)
		{
		}
	}
}
