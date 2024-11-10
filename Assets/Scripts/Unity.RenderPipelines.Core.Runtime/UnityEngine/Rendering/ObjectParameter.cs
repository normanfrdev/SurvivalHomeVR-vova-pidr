using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class ObjectParameter<T> : VolumeParameter<T>
	{
		internal ReadOnlyCollection<VolumeParameter> parameters
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

		public sealed override bool overrideState
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public sealed override T value
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public ObjectParameter(T value)
		{
			((VolumeParameter<>)(object)this)._002Ector();
		}

		internal override void Interp(VolumeParameter from, VolumeParameter to, float t)
		{
		}
	}
}
