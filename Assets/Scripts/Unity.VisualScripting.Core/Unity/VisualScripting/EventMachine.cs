using UnityEngine;

namespace Unity.VisualScripting
{
	public abstract class EventMachine<TGraph, TMacro> : Machine<TGraph, TMacro>, IEventMachine, IMachine, IGraphRoot, IGraphParent, IGraphNester, IAotStubbable where TGraph : class, IGraph, new() where TMacro : Macro<TGraph>, new()
	{
		protected void TriggerEvent(string name)
		{
		}

		protected void TriggerEvent<TArgs>(string name, TArgs args)
		{
		}

		protected void TriggerUnregisteredEvent(string name)
		{
		}

		protected virtual void TriggerRegisteredEvent<TArgs>(EventHook hook, TArgs args)
		{
		}

		protected virtual void TriggerUnregisteredEvent<TArgs>(EventHook hook, TArgs args)
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnEnable()
		{
		}

		protected virtual void Start()
		{
		}

		protected override void OnInstantiateWhileEnabled()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected override void OnUninstantiateWhileEnabled()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void TriggerAnimationEvent(AnimationEvent animationEvent)
		{
		}

		public override void TriggerUnityEvent(string name)
		{
		}

		protected virtual void OnDrawGizmos()
		{
		}

		protected virtual void OnDrawGizmosSelected()
		{
		}

		protected EventMachine()
		{
			((Machine<, >)(object)this)._002Ector();
		}
	}
}
