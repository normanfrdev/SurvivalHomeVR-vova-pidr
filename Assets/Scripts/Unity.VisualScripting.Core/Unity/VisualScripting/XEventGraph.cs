using System;

namespace Unity.VisualScripting
{
	public static class XEventGraph
	{
		public static void TriggerEventHandler<TArgs>(this GraphReference reference, Func<EventHook, bool> predicate, TArgs args, Func<IGraphParentElement, bool> recurse, bool force)
		{
		}

		public static void TriggerEventHandler<TArgs>(this GraphStack stack, Func<EventHook, bool> predicate, TArgs args, Func<IGraphParentElement, bool> recurse, bool force)
		{
		}
	}
}
