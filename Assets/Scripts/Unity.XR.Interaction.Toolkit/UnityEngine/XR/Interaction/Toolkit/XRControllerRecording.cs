using System;
using System.Collections.Generic;

namespace UnityEngine.XR.Interaction.Toolkit
{
	[Serializable]
	[CreateAssetMenu(menuName = "XR/XR Controller Recording")]
	[PreferBinarySerialization]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@3.0/api/UnityEngine.XR.Interaction.Toolkit.XRControllerRecording.html")]
	public class XRControllerRecording : ScriptableObject, ISerializationCallbackReceiver
	{
		[SerializeField]
		private bool m_SelectActivatedInFirstFrame;

		[SerializeField]
		private bool m_ActivateActivatedInFirstFrame;

		[SerializeField]
		private bool m_FirstUIPressActivatedInFirstFrame;

		[SerializeField]
		private List<XRControllerState> m_Frames;

		public List<XRControllerState> frames => null;

		public double duration => 0.0;

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}

		internal void SetFrameDependentData()
		{
		}

		public void AddRecordingFrame(XRControllerState state)
		{
		}

		public void AddRecordingFrameNonAlloc(XRControllerState state)
		{
		}

		public void InitRecording()
		{
		}

		public void SaveRecording()
		{
		}

		[Obsolete("AddRecordingFrame has been deprecated. Use the overload method with the XRControllerState parameter or the method AddRecordingFrameNonAlloc.", true)]
		public void AddRecordingFrame(double time, Vector3 position, Quaternion rotation, bool selectActive, bool activateActive, bool pressActive)
		{
		}
	}
}
