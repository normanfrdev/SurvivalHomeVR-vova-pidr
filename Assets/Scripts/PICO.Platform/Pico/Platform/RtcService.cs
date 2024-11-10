using System;
using System.Collections.Generic;
using AOT;
using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class RtcService
	{
		public delegate int ProcessAudioFrameFunction(RtcAudioFrame frame);

		private static ProcessAudioFrameFunction audioProcessor;

		public static RtcEngineInitResult InitRtcEngine()
		{
			return default(RtcEngineInitResult);
		}

		public static Task<string> GetToken(string roomId, string userId, int ttl, Dictionary<RtcPrivilege, int> privileges)
		{
			return null;
		}

		public static int JoinRoom(string roomId, string userId, string token, RtcRoomProfileType roomProfileType, bool isAutoSubscribeAudio)
		{
			return 0;
		}

		public static int JoinRoom2(RtcRoomOptions joinRoomOptions, bool leaveIfInRoom = true)
		{
			return 0;
		}

		public static int JoinRoomWithRetry(string roomId, string userId, string token, RtcRoomProfileType roomProfileType, bool isAutoSubscribeAudio)
		{
			return 0;
		}

		public static int LeaveRoom(string roomId)
		{
			return 0;
		}

		public static void SetAudioPlaybackDevice(RtcAudioPlaybackDevice device)
		{
		}

		public static void RoomPauseAllSubscribedStream(string roomId)
		{
		}

		public static void RoomResumeAllSubscribedStream(string roomId)
		{
		}

		[MonoPInvokeCallback(typeof(CLIB.RtcProcessAudioFrameFunction))]
		private static int InnerAudioProcessor(IntPtr ptr)
		{
			return 0;
		}

		public static void RegisterLocalAudioProcessor(ProcessAudioFrameFunction processor, RtcAudioChannel channel, RtcAudioSampleRate sampleRate)
		{
		}

		public static void EnableAudioPropertiesReport(int interval)
		{
		}

		public static void PublishRoom(string roomId)
		{
		}

		public static void UnPublishRoom(string roomId)
		{
		}

		public static void DestroyRoom(string roomId)
		{
		}

		public static void StartAudioCapture()
		{
		}

		public static void StopAudioCapture()
		{
		}

		public static void SetCaptureVolume(int volume)
		{
		}

		public static void SetPlaybackVolume(int volume)
		{
		}

		public static void SetEarMonitorMode(RtcEarMonitorMode mode)
		{
		}

		public static void SetEarMonitorVolume(int volume)
		{
		}

		[Obsolete("MuteLocalAudio can be replaced by UnPublishRoom(roomId)", true)]
		public static void MuteLocalAudio(RtcMuteState rtcMuteState)
		{
		}

		public static void UpdateToken(string roomId, string token)
		{
		}

		public static void SetAudioScenario(RtcAudioScenarioType scenarioType)
		{
		}

		public static void RoomSetRemoteAudioPlaybackVolume(string roomId, string userId, int volume)
		{
		}

		public static void RoomSubscribeStream(string roomId, string userId)
		{
		}

		public static void RoomUnSubscribeStream(string roomId, string userId)
		{
		}

		public static long SendRoomBinaryMessage(string roomId, byte[] message)
		{
			return 0L;
		}

		public static long SendRoomMessage(string roomId, string message)
		{
			return 0L;
		}

		public static long SendUserBinaryMessage(string roomId, string userId, byte[] message)
		{
			return 0L;
		}

		public static long SendUserMessage(string roomId, string userId, string message)
		{
			return 0L;
		}

		public static int SendStreamSyncInfo(byte[] data, int repeatCount)
		{
			return 0;
		}

		public static void SetOnTokenWillExpire(Message<string>.Handler handler)
		{
		}

		public static void SetOnRoomMessageReceived(Message<RtcRoomMessageReceived>.Handler handler)
		{
		}

		public static void SetOnRoomBinaryMessageReceived(Message<RtcBinaryMessageReceived>.Handler handler)
		{
		}

		public static void SetOnUserMessageReceived(Message<RtcUserMessageReceived>.Handler handler)
		{
		}

		public static void SetOnUserBinaryMessageReceived(Message<RtcBinaryMessageReceived>.Handler handler)
		{
		}

		public static void SetOnRoomMessageSendResult(Message<RtcMessageSendResult>.Handler handler)
		{
		}

		public static void SetOnUserMessageSendResult(Message<RtcMessageSendResult>.Handler handler)
		{
		}

		public static void SetOnUserPublishStream(Message<RtcUserPublishInfo>.Handler handler)
		{
		}

		public static void SetOnUserUnPublishStream(Message<RtcUserUnPublishInfo>.Handler handler)
		{
		}

		public static void SetOnStreamSyncInfoReceived(Message<RtcStreamSyncInfo>.Handler handler)
		{
		}

		public static void SetOnJoinRoomResultCallback(Message<RtcJoinRoomResult>.Handler handler)
		{
		}

		public static void SetOnLeaveRoomResultCallback(Message<RtcLeaveRoomResult>.Handler handler)
		{
		}

		public static void SetOnUserJoinRoomResultCallback(Message<RtcUserJoinInfo>.Handler handler)
		{
		}

		public static void SetOnUserLeaveRoomResultCallback(Message<RtcUserLeaveInfo>.Handler handler)
		{
		}

		public static void SetOnRoomStatsCallback(Message<RtcRoomStats>.Handler handler)
		{
		}

		public static void SetOnWarnCallback(Message<int>.Handler handler)
		{
		}

		public static void SetOnErrorCallback(Message<int>.Handler handler)
		{
		}

		public static void SetOnRoomWarnCallback(Message<RtcRoomWarn>.Handler handler)
		{
		}

		public static void SetOnRoomErrorCallback(Message<RtcRoomError>.Handler handler)
		{
		}

		public static void SetOnConnectionStateChangeCallback(Message<RtcConnectionState>.Handler handler)
		{
		}

		[Obsolete("SetOnUserMuteAudio is deprecated,please use SetOnUserPublishStream/SetOnUserUnPublishStream", true)]
		public static void SetOnUserMuteAudio(Message<RtcMuteInfo>.Handler handler)
		{
		}

		public static void SetOnUserStartAudioCapture(Message<string>.Handler handler)
		{
		}

		public static void SetOnUserStopAudioCapture(Message<string>.Handler handler)
		{
		}

		public static void SetOnAudioPlaybackDeviceChange(Message<RtcAudioPlaybackDevice>.Handler handler)
		{
		}

		public static void SetOnLocalAudioPropertiesReport(Message<RtcLocalAudioPropertiesReport>.Handler handler)
		{
		}

		public static void SetOnRemoteAudioPropertiesReport(Message<RtcRemoteAudioPropertiesReport>.Handler handler)
		{
		}
	}
}
