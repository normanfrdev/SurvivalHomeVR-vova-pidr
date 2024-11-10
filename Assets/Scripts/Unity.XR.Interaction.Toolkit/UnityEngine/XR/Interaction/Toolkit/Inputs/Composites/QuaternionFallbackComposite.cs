using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites
{
	[Preserve]
	public class QuaternionFallbackComposite : FallbackComposite<Quaternion>
	{
		[InputControl(layout = "Quaternion")]
		public int first;

		[InputControl(layout = "Quaternion")]
		public int second;

		[InputControl(layout = "Quaternion")]
		public int third;

		public override Quaternion ReadValue(ref InputBindingCompositeContext context)
		{
			return default(Quaternion);
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		[Preserve]
		private static void Initialize()
		{
		}

		[Preserve]
		static QuaternionFallbackComposite()
		{
		}

		public QuaternionFallbackComposite()
		{
			((FallbackComposite<>)(object)this)._002Ector();
		}
	}
}
