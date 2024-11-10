using System;
using System.Runtime.CompilerServices;

namespace Unity.XR.CoreUtils.Bindings
{
	public struct EventBinding : IEventBinding
	{
		private bool m_IsBound;

		public Action BindAction
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Action UnbindAction
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsBound => false;

		public EventBinding(Action bindAction, Action unBindAction)
		{
		}

		public void Bind()
		{
		}

		public void Unbind()
		{
		}

		public void ClearBinding()
		{
		}
	}
}
