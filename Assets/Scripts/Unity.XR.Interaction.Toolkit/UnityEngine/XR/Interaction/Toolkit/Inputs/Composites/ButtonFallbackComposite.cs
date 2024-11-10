using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites
{
	[Preserve]
	public class ButtonFallbackComposite : FallbackComposite<float>
	{
		[InputControl(layout = "Button")]
		public int first;

		[InputControl(layout = "Button")]
		public int second;

		[InputControl(layout = "Button")]
		public int third;

		public override float ReadValue(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		[Preserve]
		private static void Initialize()
		{
		}

		[Preserve]
		static ButtonFallbackComposite()
		{
		}

		public ButtonFallbackComposite()
		{
			((FallbackComposite<>)(object)this)._002Ector();
		}
	}
}
