using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting.FullSerializer
{
	public class fsMetaProperty
	{
		internal MemberInfo _memberInfo;

		public Type StorageType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Type OverrideConverterType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool CanRead
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

		public bool CanWrite
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

		public string JsonName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string MemberName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsPublic
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

		public bool IsReadOnly
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

		internal fsMetaProperty(fsConfig config, FieldInfo field)
		{
		}

		internal fsMetaProperty(fsConfig config, PropertyInfo property)
		{
		}

		private void CommonInitialize(fsConfig config)
		{
		}

		public void Write(object context, object value)
		{
		}

		public object Read(object context)
		{
			return null;
		}
	}
}
