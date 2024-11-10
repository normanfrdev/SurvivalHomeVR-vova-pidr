using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Unity.VisualScripting
{
	public static class Cloning
	{
		private static readonly Dictionary<Type, bool> skippable;

		public static HashSet<ICloner> cloners
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static ArrayCloner arrayCloner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static DictionaryCloner dictionaryCloner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static EnumerableCloner enumerableCloner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static ListCloner listCloner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static AnimationCurveCloner animationCurveCloner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal static GradientCloner gradientCloner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static FieldsCloner fieldsCloner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public static FakeSerializationCloner fakeSerializationCloner
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		static Cloning()
		{
		}

		public static object Clone(this object original, ICloner fallbackCloner, bool tryPreserveInstances)
		{
			return null;
		}

		public static T Clone<T>(this T original, ICloner fallbackCloner, bool tryPreserveInstances)
		{
			return default(T);
		}

		public static object CloneViaFakeSerialization(this object original)
		{
			return null;
		}

		public static T CloneViaFakeSerialization<T>(this T original)
		{
			return default(T);
		}

		internal static object Clone(CloningContext context, object original)
		{
			return null;
		}

		internal static void CloneInto(CloningContext context, ref object clone, object original)
		{
		}

		[CanBeNull]
		public static ICloner GetCloner(object original, Type type)
		{
			return null;
		}

		private static ICloner GetCloner(object original, Type type, ICloner fallbackCloner)
		{
			return null;
		}

		private static bool Skippable(Type type)
		{
			return false;
		}
	}
}
