using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine.InputSystem;

namespace Unity.VisualScripting.FullSerializer
{
	[UsedImplicitly]
	public class InputAction_DirectConverter : fsDirectConverter<InputAction>
	{
		protected override fsResult DoSerialize(InputAction model, Dictionary<string, fsData> serialized)
		{
			return default(fsResult);
		}

		protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref InputAction model)
		{
			return default(fsResult);
		}

		public static InputAction MakeInputActionWithId(string actionId, string actionName, string expectedControlType, InputActionType type)
		{
			return null;
		}

		public override object CreateInstance(fsData data, Type storageType)
		{
			return null;
		}

		public InputAction_DirectConverter()
		{
			((fsDirectConverter<>)(object)this)._002Ector();
		}
	}
}
