using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.VisualScripting
{
	[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
	public sealed class SingletonAttribute : Attribute
	{
		public bool Persistent
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool Automatic
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public HideFlags HideFlags
		{
			[CompilerGenerated]
			get
			{
				return default(HideFlags);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
