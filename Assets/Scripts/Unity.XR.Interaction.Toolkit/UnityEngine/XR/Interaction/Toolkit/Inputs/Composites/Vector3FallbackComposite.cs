using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Composites
{
	[Preserve]
	public class Vector3FallbackComposite : FallbackComposite<Vector3>
	{
		[InputControl(layout = "Vector3")]
		public int first;

		[InputControl(layout = "Vector3")]
		public int second;

		[InputControl(layout = "Vector3")]
		public int third;

		public override Vector3 ReadValue(ref InputBindingCompositeContext context)
		{
			return default(Vector3);
		}

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		[Preserve]
		private static void Initialize()
		{
		}

		[Preserve]
		static Vector3FallbackComposite()
		{
		}

		public Vector3FallbackComposite()
		{
			((FallbackComposite<>)(object)this)._002Ector();
		}
	}
}
