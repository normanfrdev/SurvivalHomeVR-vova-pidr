using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites
{
	[Preserve]
	public class IntegerFallbackComposite : FallbackComposite<int>
	{
		[InputControl(layout = "Integer")]
		public int first;

		[InputControl(layout = "Integer")]
		public int second;

		[InputControl(layout = "Integer")]
		public int third;

		public override int ReadValue(ref InputBindingCompositeContext context)
		{
			return 0;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		[Preserve]
		private static void Initialize()
		{
		}

		[Preserve]
		static IntegerFallbackComposite()
		{
		}

		public IntegerFallbackComposite()
		{
			((FallbackComposite<>)(object)this)._002Ector();
		}
	}
}
