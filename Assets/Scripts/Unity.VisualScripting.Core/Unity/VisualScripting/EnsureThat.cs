using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace Unity.VisualScripting
{
	public class EnsureThat
	{
		internal string paramName;

		public void IsTrue(bool value)
		{
		}

		public void IsFalse(bool value)
		{
		}

		public void HasItems<T>(T value) where T : class, ICollection
		{
		}

		public void HasItems<T>(ICollection<T> value)
		{
		}

		public void HasItems<T>(T[] value)
		{
		}

		public void HasNoNullItem<T>(T value) where T : class, IEnumerable
		{
		}

		public void HasItems<T>(IList<T> value)
		{
		}

		public void HasItems<TKey, TValue>(IDictionary<TKey, TValue> value)
		{
		}

		public void SizeIs<T>(T[] value, int expected)
		{
		}

		public void SizeIs<T>(T[] value, long expected)
		{
		}

		public void SizeIs<T>(T value, int expected) where T : ICollection
		{
		}

		public void SizeIs<T>(T value, long expected) where T : ICollection
		{
		}

		public void SizeIs<T>(ICollection<T> value, int expected)
		{
		}

		public void SizeIs<T>(ICollection<T> value, long expected)
		{
		}

		public void SizeIs<T>(IList<T> value, int expected)
		{
		}

		public void SizeIs<T>(IList<T> value, long expected)
		{
		}

		public void SizeIs<TKey, TValue>(IDictionary<TKey, TValue> value, int expected)
		{
		}

		public void SizeIs<TKey, TValue>(IDictionary<TKey, TValue> value, long expected)
		{
		}

		public void IsKeyOf<TKey, TValue>(IDictionary<TKey, TValue> value, TKey expectedKey, string keyLabel = null)
		{
		}

		public void Any<T>(IList<T> value, Func<T, bool> predicate)
		{
		}

		public void Any<T>(ICollection<T> value, Func<T, bool> predicate)
		{
		}

		public void Any<T>(T[] value, Func<T, bool> predicate)
		{
		}

		public void Is<T>(T param, T expected) where T : struct, IComparable<T>
		{
		}

		public void IsNot<T>(T param, T expected) where T : struct, IComparable<T>
		{
		}

		public void IsLt<T>(T param, T limit) where T : struct, IComparable<T>
		{
		}

		public void IsLte<T>(T param, T limit) where T : struct, IComparable<T>
		{
		}

		public void IsGt<T>(T param, T limit) where T : struct, IComparable<T>
		{
		}

		public void IsGte<T>(T param, T limit) where T : struct, IComparable<T>
		{
		}

		public void IsInRange<T>(T param, T min, T max) where T : struct, IComparable<T>
		{
		}

		public void IsNotEmpty(Guid value)
		{
		}

		public void IsNotNull<T>(T? value) where T : struct
		{
		}

		public void IsNull<T>([NoEnumeration] T value)
		{
		}

		public void IsNotNull<T>([NoEnumeration] T value)
		{
		}

		public void HasAttribute(Type param, Type attributeType)
		{
		}

		public void HasAttribute<TAttribute>(Type param) where TAttribute : Attribute
		{
		}

		private void HasConstructorAccepting(Type param, Type[] parameterTypes, bool nonPublic)
		{
		}

		public void HasConstructorAccepting(Type param, params Type[] parameterTypes)
		{
		}

		public void HasPublicConstructorAccepting(Type param, params Type[] parameterTypes)
		{
		}

		public void IsNotNullOrWhiteSpace(string value)
		{
		}

		public void IsNotNullOrEmpty(string value)
		{
		}

		public void IsNotNull(string value)
		{
		}

		public void IsNotEmpty(string value)
		{
		}

		public void HasLengthBetween(string value, int minLength, int maxLength)
		{
		}

		public void Matches(string value, string match)
		{
		}

		public void Matches(string value, Regex match)
		{
		}

		public void SizeIs(string value, int expected)
		{
		}

		public void IsEqualTo(string value, string expected)
		{
		}

		public void IsEqualTo(string value, string expected, StringComparison comparison)
		{
		}

		public void IsNotEqualTo(string value, string expected)
		{
		}

		public void IsNotEqualTo(string value, string expected, StringComparison comparison)
		{
		}

		public void IsGuid(string value)
		{
		}

		private bool StringEquals(string x, string y, StringComparison? comparison = null)
		{
			return false;
		}

		public void IsOfType<T>(T param, Type expectedType)
		{
		}

		public void IsOfType(Type param, Type expectedType)
		{
		}

		public void IsOfType<T>(object param)
		{
		}

		public void IsOfType<T>(Type param)
		{
		}

		public void IsNotDefault<T>(T param) where T : struct
		{
		}
	}
}
