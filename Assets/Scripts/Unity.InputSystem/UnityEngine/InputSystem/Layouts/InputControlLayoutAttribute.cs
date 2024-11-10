using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Layouts
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class InputControlLayoutAttribute : Attribute
	{
		internal bool? canRunInBackgroundInternal;

		internal bool? updateBeforeRenderInternal;

		public Type stateType
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

		public string stateFormat
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

		public string[] commonUsages
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

		public string variants
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

		public bool isNoisy
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

		public bool canRunInBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool updateBeforeRender
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isGenericTypeOfDevice
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

		public string displayName
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

		public string description
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

		public bool hideInUI
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
	}
}
