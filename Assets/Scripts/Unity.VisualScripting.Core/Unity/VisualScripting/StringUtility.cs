using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Unity.VisualScripting
{
	public static class StringUtility
	{
		[CompilerGenerated]
		private sealed class _003CAllIndexesOf_003Ed__8 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private int _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private string needle;

			public string _003C_003E3__needle;

			private string haystack;

			public string _003C_003E3__haystack;

			private int _003Cindex_003E5__2;

			int IEnumerator<int>.Current
			{
				[DebuggerHidden]
				get
				{
					return 0;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CAllIndexesOf_003Ed__8(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<int> IEnumerable<int>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly Regex guidRegex;

		public static bool IsNullOrWhiteSpace(string s)
		{
			return false;
		}

		public static string FallbackEmpty(string s, string fallback)
		{
			return null;
		}

		public static string FallbackWhitespace(string s, string fallback)
		{
			return null;
		}

		public static void AppendLineFormat(this StringBuilder sb, string format, params object[] args)
		{
		}

		public static string ToSeparatedString(this IEnumerable enumerable, string separator)
		{
			return null;
		}

		public static string ToCommaSeparatedString(this IEnumerable enumerable)
		{
			return null;
		}

		public static string ToLineSeparatedString(this IEnumerable enumerable)
		{
			return null;
		}

		public static bool ContainsInsensitive(this string haystack, string needle)
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CAllIndexesOf_003Ed__8))]
		public static IEnumerable<int> AllIndexesOf(this string haystack, string needle)
		{
			return null;
		}

		public static string Filter(this string s, bool letters = true, bool numbers = true, bool whitespace = true, bool symbols = true, bool punctuation = true)
		{
			return null;
		}

		public static string FilterReplace(this string s, char replacement, bool merge, bool letters = true, bool numbers = true, bool whitespace = true, bool symbols = true, bool punctuation = true)
		{
			return null;
		}

		public static string Prettify(this string s)
		{
			return null;
		}

		public static bool IsWordDelimiter(char c)
		{
			return false;
		}

		public static bool IsWordBeginning(char? previous, char current, char? next)
		{
			return false;
		}

		public static bool IsWordBeginning(string s, int index)
		{
			return false;
		}

		public static string SplitWords(this string s, char separator)
		{
			return null;
		}

		public static string RemoveConsecutiveCharacters(this string s, char c)
		{
			return null;
		}

		public static string ReplaceMultiple(this string s, HashSet<char> haystacks, char replacement)
		{
			return null;
		}

		public static string Truncate(this string value, int maxLength, string suffix = "...")
		{
			return null;
		}

		public static string TrimEnd(this string source, string value)
		{
			return null;
		}

		public static string TrimStart(this string source, string value)
		{
			return null;
		}

		public static string FirstCharacterToLower(this string s)
		{
			return null;
		}

		public static string FirstCharacterToUpper(this string s)
		{
			return null;
		}

		public static string PartBefore(this string s, char c)
		{
			return null;
		}

		public static string PartAfter(this string s, char c)
		{
			return null;
		}

		public static void PartsAround(this string s, char c, out string before, out string after)
		{
			before = null;
			after = null;
		}

		public static bool EndsWith(this string s, char c)
		{
			return false;
		}

		public static bool StartsWith(this string s, char c)
		{
			return false;
		}

		public static bool Contains(this string s, char c)
		{
			return false;
		}

		public static string NullIfEmpty(this string s)
		{
			return null;
		}

		public static string ToBinaryString(this int value)
		{
			return null;
		}

		public static string ToBinaryString(this long value)
		{
			return null;
		}

		public static string ToBinaryString(this Enum value)
		{
			return null;
		}

		public static int CountIndices(this string s, char c)
		{
			return 0;
		}

		public static bool IsGuid(string value)
		{
			return false;
		}

		public static string PathEllipsis(string s, int maxLength)
		{
			return null;
		}

		public static string ToHexString(this byte[] bytes)
		{
			return null;
		}
	}
}
