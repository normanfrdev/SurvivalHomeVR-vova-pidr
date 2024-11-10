using System;
using System.Collections.Generic;

namespace UnityEngine.XR.OpenXR.Features
{
	[Serializable]
	public abstract class OpenXRInteractionFeature : OpenXRFeature
	{
		[Serializable]
		protected internal enum ActionType
		{
			Binary = 0,
			Axis1D = 1,
			Axis2D = 2,
			Pose = 3,
			Vibrate = 4,
			Count = 5
		}

		[Serializable]
		protected internal class ActionBinding
		{
			public string interactionProfileName;

			public string interactionPath;

			public List<string> userPaths;
		}

		[Serializable]
		protected internal class ActionConfig
		{
			public string name;

			public ActionType type;

			public string localizedName;

			public List<ActionBinding> bindings;

			public List<string> usages;

			public bool isAdditive;
		}

		protected internal class DeviceConfig
		{
			public InputDeviceCharacteristics characteristics;

			public string userPath;
		}

		[Serializable]
		protected internal class ActionMapConfig
		{
			public string name;

			public string localizedName;

			public List<DeviceConfig> deviceInfos;

			public List<ActionConfig> actions;

			public string desiredInteractionProfile;

			public string manufacturer;

			public string serialNumber;
		}

		public static class UserPaths
		{
			public const string leftHand = "/user/hand/left";

			public const string rightHand = "/user/hand/right";

			public const string head = "/user/head";

			public const string gamepad = "/user/gamepad";

			public const string treadmill = "/user/treadmill";
		}

		public enum InteractionProfileType
		{
			Device = 0,
			XRController = 1
		}

		private static List<ActionMapConfig> m_CreatedActionMaps;

		private static Dictionary<InteractionProfileType, Dictionary<string, bool>> m_InteractionProfileEnabledMaps;

		internal virtual bool IsAdditive => false;

		protected virtual void RegisterDeviceLayout()
		{
		}

		protected virtual void UnregisterDeviceLayout()
		{
		}

		protected virtual void RegisterActionMapsWithRuntime()
		{
		}

		protected internal override bool OnInstanceCreate(ulong xrSession)
		{
			return false;
		}

		protected virtual InteractionProfileType GetInteractionProfileType()
		{
			return default(InteractionProfileType);
		}

		protected virtual string GetDeviceLayoutName()
		{
			return null;
		}

		internal void CreateActionMaps(List<ActionMapConfig> configs)
		{
		}

		protected void AddActionMap(ActionMapConfig map)
		{
		}

		internal virtual void AddAdditiveActions(List<ActionMapConfig> actionMaps, ActionMapConfig additiveMap)
		{
		}

		protected internal override void OnEnabledChange()
		{
		}

		internal static void RegisterLayouts()
		{
		}
	}
}
