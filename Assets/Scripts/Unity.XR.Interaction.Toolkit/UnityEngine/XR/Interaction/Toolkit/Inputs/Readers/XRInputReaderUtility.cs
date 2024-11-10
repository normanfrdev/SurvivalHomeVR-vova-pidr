using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Haptics;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	public static class XRInputReaderUtility
	{
		public static void SetInputProperty(ref XRInputHapticImpulseProvider property, XRInputHapticImpulseProvider value, Behaviour behavior)
		{
		}

		public static void SetInputProperty(ref XRInputButtonReader property, XRInputButtonReader value, Behaviour behavior)
		{
		}

		public static void SetInputProperty<TValue>(ref XRInputValueReader<TValue> property, XRInputValueReader<TValue> value, Behaviour behavior) where TValue : struct
		{
		}

		internal static void SetInputProperty(ref XRInputButtonReader property, XRInputButtonReader value, Behaviour behavior, List<XRInputButtonReader> buttonReaders)
		{
		}

		internal static void SetInputProperty<TValue>(ref XRInputValueReader<TValue> property, XRInputValueReader<TValue> value, Behaviour behavior, List<XRInputValueReader> valueReaders) where TValue : struct
		{
		}
	}
}
