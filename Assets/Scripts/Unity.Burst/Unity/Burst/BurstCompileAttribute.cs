using System;
using System.Runtime.CompilerServices;

namespace Unity.Burst
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
	public class BurstCompileAttribute : Attribute
	{
		internal bool? _compileSynchronously;

		internal bool? _debug;

		internal bool? _disableSafetyChecks;

		internal bool? _disableDirectCall;

		public FloatMode FloatMode
		{
			[CompilerGenerated]
			get
			{
				return default(FloatMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FloatPrecision FloatPrecision
		{
			[CompilerGenerated]
			get
			{
				return default(FloatPrecision);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool CompileSynchronously
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Debug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DisableSafetyChecks
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DisableDirectCall
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public OptimizeFor OptimizeFor
		{
			[CompilerGenerated]
			get
			{
				return default(OptimizeFor);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal string[] Options
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

		public BurstCompileAttribute()
		{
		}

		public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode)
		{
		}

		internal BurstCompileAttribute(string[] options)
		{
		}
	}
}
