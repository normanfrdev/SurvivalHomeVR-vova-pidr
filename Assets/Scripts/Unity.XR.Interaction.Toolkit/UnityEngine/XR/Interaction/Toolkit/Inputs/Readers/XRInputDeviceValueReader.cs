namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
	public abstract class XRInputDeviceValueReader : ScriptableObject
	{
		[SerializeField]
		[Tooltip("Characteristics of the input device to read from. Controllers are either:\nHeld In Hand, Tracked Device, Controller, Left\nHeld In Hand, Tracked Device, Controller, Right")]
		private protected InputDeviceCharacteristics m_Characteristics;

		public InputDeviceCharacteristics characteristics
		{
			get
			{
				return default(InputDeviceCharacteristics);
			}
			set
			{
			}
		}
	}
	public abstract class XRInputDeviceValueReader<TValue> : XRInputDeviceValueReader, IXRInputValueReader<TValue>, IXRInputValueReader where TValue : struct
	{
		[SerializeField]
		[Tooltip("The name of the input feature to read.")]
		private InputFeatureUsageString<TValue> m_Usage;

		private InputDevice m_InputDevice;

		public InputFeatureUsageString<TValue> usage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract TValue ReadValue();

		public abstract bool TryReadValue(out TValue value);

		protected bool ReadBoolValue()
		{
			return false;
		}

		protected uint ReadUIntValue()
		{
			return 0u;
		}

		protected float ReadFloatValue()
		{
			return 0f;
		}

		protected Vector2 ReadVector2Value()
		{
			return default(Vector2);
		}

		protected Vector3 ReadVector3Value()
		{
			return default(Vector3);
		}

		protected Quaternion ReadQuaternionValue()
		{
			return default(Quaternion);
		}

		protected InputTrackingState ReadInputTrackingStateValue()
		{
			return default(InputTrackingState);
		}

		protected bool TryReadBoolValue(out bool value)
		{
			value = default(bool);
			return false;
		}

		protected bool TryReadUIntValue(out uint value)
		{
			value = default(uint);
			return false;
		}

		protected bool TryReadFloatValue(out float value)
		{
			value = default(float);
			return false;
		}

		protected bool TryReadVector2Value(out Vector2 value)
		{
			value = default(Vector2);
			return false;
		}

		protected bool TryReadVector3Value(out Vector3 value)
		{
			value = default(Vector3);
			return false;
		}

		protected bool TryReadQuaternionValue(out Quaternion value)
		{
			value = default(Quaternion);
			return false;
		}

		protected bool TryReadInputTrackingStateValue(out InputTrackingState value)
		{
			value = default(InputTrackingState);
			return false;
		}

		protected bool RefreshInputDeviceIfNeeded()
		{
			return false;
		}
	}
}
