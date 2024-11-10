using System;
using System.Runtime.CompilerServices;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class SerializedPropertyProviderAttribute : Attribute, IDecoratorAttribute
	{
		public Type type
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

		public SerializedPropertyProviderAttribute(Type type)
		{
		}
	}
}
