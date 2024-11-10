using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[SerializationVersion("A", new Type[] { })]
	public sealed class Member : ISerializationCallbackReceiver
	{
		public enum Source
		{
			Unknown = 0,
			Field = 1,
			Property = 2,
			Method = 3,
			Constructor = 4
		}

		[SerializeAs("name")]
		private string _name;

		[SerializeAs("parameterTypes")]
		private Type[] _parameterTypes;

		[SerializeAs("targetType")]
		private Type _targetType;

		[SerializeAs("targetTypeName")]
		private string _targetTypeName;

		[DoNotSerialize]
		private Source _source;

		[DoNotSerialize]
		private FieldInfo _fieldInfo;

		[DoNotSerialize]
		private PropertyInfo _propertyInfo;

		[DoNotSerialize]
		private MethodInfo _methodInfo;

		[DoNotSerialize]
		private ConstructorInfo _constructorInfo;

		[DoNotSerialize]
		private bool _isExtension;

		[DoNotSerialize]
		private bool _isInvokedAsExtension;

		[DoNotSerialize]
		private IOptimizedAccessor fieldAccessor;

		[DoNotSerialize]
		private IOptimizedAccessor propertyAccessor;

		[DoNotSerialize]
		private IOptimizedInvoker methodInvoker;

		public const MemberTypes SupportedMemberTypes = MemberTypes.Constructor | MemberTypes.Field | MemberTypes.Method | MemberTypes.Property;

		public const BindingFlags SupportedBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

		private static readonly object[] EmptyObjects;

		[DoNotSerialize]
		public Type targetType
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public string targetTypeName => null;

		[DoNotSerialize]
		public string name
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public bool isReflected
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[DoNotSerialize]
		public Source source
		{
			get
			{
				return default(Source);
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public FieldInfo fieldInfo
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public PropertyInfo propertyInfo
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public MethodInfo methodInfo
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public ConstructorInfo constructorInfo
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public bool isExtension
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public bool isInvokedAsExtension
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		[DoNotSerialize]
		public Type[] parameterTypes
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public MethodBase methodBase => null;

		private MemberInfo _info => null;

		public MemberInfo info => null;

		public Type type => null;

		public bool isCoroutine => false;

		public bool isYieldInstruction => false;

		public bool isGettable => false;

		public bool isPubliclyGettable => false;

		public bool isSettable => false;

		public bool isPubliclySettable => false;

		public bool isInvocable => false;

		public bool isPubliclyInvocable => false;

		public bool isAccessor => false;

		public bool isField => false;

		public bool isProperty => false;

		public bool isMethod => false;

		public bool isConstructor => false;

		public bool requiresTarget => false;

		public bool isOperator => false;

		public bool isConversion => false;

		public int order => 0;

		public Type declaringType => null;

		public bool isInherited => false;

		public Type pseudoDeclaringType => null;

		public bool isPseudoInherited => false;

		public bool isIndexer => false;

		public bool isPredictable => false;

		public bool allowsNull => false;

		[Obsolete("This parameterless constructor is only made public for serialization. Use another constructor instead.")]
		public Member()
		{
		}

		public Member(Type targetType, string name, Type[] parameterTypes = null)
		{
		}

		public Member(Type targetType, FieldInfo fieldInfo)
		{
		}

		public Member(Type targetType, PropertyInfo propertyInfo)
		{
		}

		public Member(Type targetType, MethodInfo methodInfo)
		{
		}

		public Member(Type targetType, ConstructorInfo constructorInfo)
		{
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		public bool IsGettable(bool nonPublic)
		{
			return false;
		}

		public bool IsSettable(bool nonPublic)
		{
			return false;
		}

		public bool IsInvocable(bool nonPublic)
		{
			return false;
		}

		private void EnsureExplicitParameterTypes()
		{
		}

		public void Reflect()
		{
		}

		private void ReflectField(IEnumerable<MemberInfo> candidates)
		{
		}

		private void ReflectProperty(IEnumerable<MemberInfo> candidates)
		{
		}

		private void ReflectConstructor(IEnumerable<MemberInfo> candidates)
		{
		}

		private void ReflectMethod(IEnumerable<MemberInfo> candidates)
		{
		}

		public void Prewarm()
		{
		}

		public void EnsureReflected()
		{
		}

		public void EnsureReady(object target)
		{
		}

		public object Get(object target)
		{
			return null;
		}

		public T Get<T>(object target)
		{
			return default(T);
		}

		public object Set(object target, object value)
		{
			return null;
		}

		private void EnsureInvocable(object target)
		{
		}

		public IEnumerable<ParameterInfo> GetParameterInfos()
		{
			return null;
		}

		public object Invoke(object target)
		{
			return null;
		}

		public object Invoke(object target, object arg0)
		{
			return null;
		}

		public object Invoke(object target, object arg0, object arg1)
		{
			return null;
		}

		public object Invoke(object target, object arg0, object arg1, object arg2)
		{
			return null;
		}

		public object Invoke(object target, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		public object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4)
		{
			return null;
		}

		public object Invoke(object target, params object[] arguments)
		{
			return null;
		}

		public T Invoke<T>(object target)
		{
			return default(T);
		}

		public T Invoke<T>(object target, object arg0)
		{
			return default(T);
		}

		public T Invoke<T>(object target, object arg0, object arg1)
		{
			return default(T);
		}

		public T Invoke<T>(object target, object arg0, object arg1, object arg2)
		{
			return default(T);
		}

		public T Invoke<T>(object target, object arg0, object arg1, object arg2, object arg3)
		{
			return default(T);
		}

		public T Invoke<T>(object target, object arg0, object arg1, object arg2, object arg3, object arg4)
		{
			return default(T);
		}

		public T Invoke<T>(object target, params object[] arguments)
		{
			return default(T);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(Member a, Member b)
		{
			return false;
		}

		public static bool operator !=(Member a, Member b)
		{
			return false;
		}

		public string ToUniqueString()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public Member ToDeclarer()
		{
			return null;
		}

		public Member ToPseudoDeclarer()
		{
			return null;
		}
	}
}
