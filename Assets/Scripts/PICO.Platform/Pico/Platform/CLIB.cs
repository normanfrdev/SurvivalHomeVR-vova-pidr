using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Pico.Platform
{
	public class CLIB
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public struct __Internal
		{
			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PopMessage();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_FreeMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfAchievementType_ToString(AchievementType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern AchievementType ppfAchievementType_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfAchievementWritePolicy_ToString(AchievementWritePolicy value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern AchievementWritePolicy ppfAchievementWritePolicy_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfKeyValuePairType_ToString(KVPairType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern KVPairType ppfKeyValuePairType_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfMatchmakingCriterionImportance_ToString(MatchmakingCriterionImportance value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern MatchmakingCriterionImportance ppfMatchmakingCriterionImportance_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AchievementDefinition_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementDefinition_GetName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_AchievementDefinition_GetBitfieldLength(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_AchievementDefinition_GetTarget(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern AchievementType ppf_AchievementDefinition_GetType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern AchievementWritePolicy ppf_AchievementDefinition_GetWritePolicy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AchievementDefinition_IsArchived(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AchievementDefinition_IsSecret(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementDefinition_GetTitle(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementDefinition_GetDescription(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementDefinition_GetUnlockedDescription(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementDefinition_GetLockedImageURL(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementDefinition_GetUnlockedImageURL(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementDefinitionArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementDefinitionArray_GetNextUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_AchievementDefinitionArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_AchievementDefinitionArray_GetTotalSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AchievementDefinitionArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AchievementProgress_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementProgress_GetBitfield(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_AchievementProgress_GetCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AchievementProgress_GetIsUnlocked(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementProgress_GetName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AchievementProgress_GetUnlockTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementProgress_GetExtraData(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_AchievementProgress_GetExtraDataLength(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementProgressArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementProgressArray_GetNextUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_AchievementProgressArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_AchievementProgressArray_GetTotalSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AchievementProgressArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AchievementUpdate_GetJustUnlocked(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AchievementUpdate_GetName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationByMessageOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByMessageOptions_Destroy(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByMessageOptions_SetMessageData(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationByPresenceOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByPresenceOptions_Destroy(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByPresenceOptions_SetDeeplinkMessage(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByPresenceOptions_SetDestinationApiName(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByPresenceOptions_SetLobbySessionId(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByPresenceOptions_SetMatchSessionId(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByPresenceOptions_SetTrackingId(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationByPresenceOptions_SetExtra(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Destination_GetApiName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Destination_GetDeeplinkMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Destination_GetDisplayName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetDisplayName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetImageUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetInviteToken(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetSmallImageUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UserPresenceStatus ppf_User_GetPresenceStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern Gender ppf_User_GetGender(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetPresence(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetPresenceDeeplinkMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetPresenceDestinationApiName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetPresenceLobbySessionId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetPresenceMatchSessionId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetPresencePackage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetPresenceExtra(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_User_GetPresenceIsJoinable(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_User_GetStoreRegion(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationInvite_GetDestination(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationInvite_GetRecipient(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_ApplicationInvite_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_ApplicationInvite_GetIsActive(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationInvite_GetLobbySessionId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationInvite_GetMatchSessionId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationInviteArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationInviteArray_GetNextPageParam(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_ApplicationInviteArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_ApplicationInviteArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationOptions_Destroy(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationOptions_SetDeeplinkMessage(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_ApplicationVersion_GetCurrentCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationVersion_GetCurrentName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_ApplicationVersion_GetLatestCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationVersion_GetLatestName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AsrResult_GetText(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AsrResult_GetIsFinalResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AsrResult_GetSessionId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetDetails_GetAssetId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetAssetType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetDownloadStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetFilepath(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetIapStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetMetadata(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetFilename(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_AssetDetails_GetVersion(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetIapSku(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetIapName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetIapPrice(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetIapCurrency(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetIapDescription(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetails_GetIapIcon(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetailsArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_AssetDetailsArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AssetDetailsArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetDetailsArray_GetNextPageParam(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFileDeleteForSafety_GetAssetId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetFileDeleteForSafety_GetReason(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFileDeleteResult_GetAssetId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetFileDeleteResult_GetFilepath(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AssetFileDeleteResult_GetSuccess(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFileDownloadCancelResult_GetAssetId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetFileDownloadCancelResult_GetFilepath(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_AssetFileDownloadCancelResult_GetSuccess(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFileDownloadResult_GetAssetId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetFileDownloadResult_GetFilepath(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFileDownloadUpdate_GetAssetId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFileDownloadUpdate_GetBytesTotal(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_AssetFileDownloadUpdate_GetBytesTransferred(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern AssetFileDownloadCompleteStatus ppf_AssetFileDownloadUpdate_GetCompleteStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetStatus_GetAssetId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetStatus_GetFilename(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetStatus_GetFilepath(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_AssetStatus_GetDownloadStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_CaptureInfo_GetImagePath(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_CaptureInfo_GetJobId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfChallengeCreationType_ToString(ChallengeCreationType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ChallengeCreationType ppfChallengeCreationType_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfChallengeVisibility_ToString(ChallengeVisibility value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ChallengeVisibility ppfChallengeVisibility_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Leaderboard_GetDestination(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Leaderboard_GetApiName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_UserArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_UserArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_UserArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_UserArray_GetNextPageParam(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ChallengeCreationType ppf_Challenge_GetCreationType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Challenge_GetInvitedUsers(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Challenge_GetLeaderboard(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Challenge_GetParticipants(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Challenge_GetTitle(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ChallengeVisibility ppf_Challenge_GetVisibility(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenge_GetEndDate(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenge_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenge_GetStartDate(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeArray_GetNextUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeArray_GetPreviousUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_ChallengeArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_ChallengeArray_GetTotalCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_ChallengeArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_ChallengeArray_HasPreviousPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeEntry_GetDisplayScore(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeEntry_GetExtraData(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_ChallengeEntry_GetExtraDataLength(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_ChallengeEntry_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_ChallengeEntry_GetRank(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_ChallengeEntry_GetScore(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_ChallengeEntry_GetTimestamp(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeEntry_GetUser(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeEntryArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeEntryArray_GetNextUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeEntryArray_GetPreviousUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_ChallengeEntryArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_ChallengeEntryArray_GetTotalCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_ChallengeEntryArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_ChallengeEntryArray_HasPreviousPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfChallengeViewerFilter_ToString(ChallengeViewerFilter value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ChallengeViewerFilter ppfChallengeViewerFilter_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ChallengeOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_Destroy(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetEndDate(IntPtr handle, ulong value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetIncludeActiveChallenges(IntPtr handle, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetIncludeFutureChallenges(IntPtr handle, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetIncludePastChallenges(IntPtr handle, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetLeaderboardName(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetStartDate(IntPtr handle, ulong value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetTitle(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetViewerFilter(IntPtr handle, ChallengeViewerFilter value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ChallengeOptions_SetVisibility(IntPtr handle, ChallengeVisibility value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_DataStore_Contains(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string key);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_DataStore_GetKey(IntPtr obj, int index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_DataStore_GetNumKeys(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_DataStore_GetValue(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string key);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_DestinationArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_DestinationArray_GetNextPageParam(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_DestinationArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_DestinationArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_DetectSensitiveResult_GetFilteredText(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern SensitiveProposal ppf_DetectSensitiveResult_GetProposal(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_EntitlementCheckResult_GetHasEntitlement(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_EntitlementCheckResult_GetStatusCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_EntitlementCheckResult_GetStatusMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Error_GetMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Error_GetCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LaunchDetails_GetDeeplinkMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LaunchDetails_GetDestinationApiName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LaunchDetails_GetLobbySessionID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LaunchDetails_GetMatchSessionID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LaunchDetails_GetExtra(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_LaunchDetails_GetRoomID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_LaunchDetails_GetChallengeID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LaunchDetails_GetTrackingID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern LaunchType ppf_LaunchDetails_GetLaunchType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LaunchDetails_GetClientAction(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SystemInfo_GetROMVersion(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SystemInfo_GetLocale(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SystemInfo_GetProductName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_SystemInfo_GetIsCnDevice(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SystemInfo_GetMatrixVersionName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SystemInfo_GetMatrixVersionCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ApplicationLifecycle_GetLaunchDetails();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ApplicationLifecycle_LogDeeplinkResult([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string trackingID, LaunchResult result);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Application_GetSystemInfo();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Packet_Free(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Packet_GetBytes(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Packet_GetSenderID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_Packet_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Net_ReadPacket();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_Net_SendPacket([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userID, UIntPtr length, IntPtr bytes);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_Net_SendPacket2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userID, UIntPtr length, IntPtr bytes, bool reliable);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_Net_SendPacketToCurrentRoom(UIntPtr length, IntPtr bytes);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_Net_SendPacketToCurrentRoom2(UIntPtr length, IntPtr bytes, bool reliable);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioPropertyOptions_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcAudioPropertyOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioPropertyOptions_SetInterval(IntPtr obj, int value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcStreamSyncInfoOptions_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcStreamSyncInfoOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcStreamSyncInfoOptions_SetStreamIndex(IntPtr obj, RtcStreamIndex value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcStreamSyncInfoOptions_SetRepeatCount(IntPtr obj, int value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcStreamSyncInfoOptions_SetStreamType(IntPtr obj, RtcSyncInfoStreamType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcRoomOptions_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRoomOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcRoomOptions_SetRoomProfileType(IntPtr obj, RtcRoomProfileType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcRoomOptions_SetIsAutoSubscribeAudio(IntPtr obj, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcRoomOptions_SetRoomId(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcRoomOptions_SetUserId(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcRoomOptions_SetUserExtra(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcRoomOptions_SetToken(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioFrameOptions_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcAudioFrameOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioFrameOptions_SetSampleRate(IntPtr obj, RtcAudioSampleRate value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioFrameOptions_SetChannel(IntPtr obj, RtcAudioChannel value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioFrameOptions_SetTimeStampInUs(IntPtr obj, long value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioFrameOptions_SetData(IntPtr obj, IntPtr value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioFrameOptions_SetDataSize(IntPtr obj, long value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcAudioFrameOptions_SetDeepCopy(IntPtr obj, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcEngineInitResult ppf_Rtc_InitRtcEngine();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_UnInitRtcEngine();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Rtc_JoinRoom(IntPtr roomOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Rtc_LeaveRoom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_DestroyRoom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_PublishRoom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_UnPublishRoom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_UpdateToken([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string token);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_EnableAudioPropertiesReport(IntPtr config);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_MuteLocalAudio(RtcMuteState muteState);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_RoomPauseAllSubscribedStream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, RtcPauseResumeMediaType mediaType);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_RoomResumeAllSubscribedStream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, RtcPauseResumeMediaType mediaType);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_SetAudioPlaybackDevice(RtcAudioPlaybackDevice device);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_SetAudioScenario(RtcAudioScenarioType scenario);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_SetCaptureVolume(RtcStreamIndex index, int volume);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_SetEarMonitorMode(RtcEarMonitorMode earMonitorMode);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_SetEarMonitorVolume(int volume);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_SetPlaybackVolume(int volume);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_StartAudioCapture();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_StopAudioCapture();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_RoomPublishStream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, RtcMediaStreamType streamType);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_RoomSetRemoteAudioPlaybackVolume([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userId, int volume);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_RoomSubscribeStream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userId, RtcMediaStreamType mediaType);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_RoomUnPublishStream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, RtcMediaStreamType streamType);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_RoomUnsubscribeStream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userId, RtcMediaStreamType mediaType);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_Rtc_SendRoomBinaryMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, IntPtr message, int length);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_Rtc_SendRoomMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string message);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Rtc_SendStreamSyncInfo(IntPtr data, int length, IntPtr config);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_Rtc_SendUserBinaryMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userId, IntPtr message, int length);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_Rtc_SendUserMessage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string roomId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string message);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Rtc_SetAudioSourceType(RtcAudioSourceType type);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Rtc_SetScreenAudioSourceType(RtcAudioSourceType sourceType);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Rtc_PushExternalAudioFrame(IntPtr audioFrame);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_StartAsrOptions_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_StartAsrOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_StartAsrOptions_SetAutoStop(IntPtr obj, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_StartAsrOptions_SetVadMaxDurationInSeconds(IntPtr obj, int value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_StartAsrOptions_SetShowPunctual(IntPtr obj, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern AsrEngineInitResult ppf_Speech_InitAsrEngine();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Speech_StartAsr(IntPtr option);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_Speech_StopAsr();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Game_InitializeWithToken([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string accessToken);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Game_InitializeWithTokenAccountTypeOne([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string accessToken);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Game_InitializeAuto();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_Game_UnInitialize();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_InviteOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_InviteOptions_Destroy(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_InviteOptions_AddSuggestedUser(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_InviteOptions_ClearSuggestedUsers(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_KeyValuePair_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_KeyValuePair_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_KeyValuePair_GetKey(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_KeyValuePair_SetKey(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string key);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern KVPairType ppf_KeyValuePair_GetValueType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_KeyValuePair_GetIntValue(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_KeyValuePair_SetIntValue(IntPtr obj, int value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_KeyValuePair_GetDoubleValue(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_KeyValuePair_SetDoubleValue(IntPtr obj, double value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_KeyValuePair_GetStringValue(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_KeyValuePair_SetStringValue(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_KeyValuePairArray_Create(UIntPtr size);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_KeyValuePairArray_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_KeyValuePairArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_LaunchFriendRequestFlowResult_GetDidCancel(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_LaunchFriendRequestFlowResult_GetDidSendRequest(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardArray_GetNextUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_LeaderboardArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_LeaderboardArray_GetTotalCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_LeaderboardArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_SupplementaryMetric_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SupplementaryMetric_GetMetric(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardEntry_GetSupplementaryMetric(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardEntry_GetDisplayScore(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardEntry_GetExtraData(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_LeaderboardEntry_GetExtraDataLength(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_LeaderboardEntry_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_LeaderboardEntry_GetRank(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_LeaderboardEntry_GetScore(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_LeaderboardEntry_GetTimestamp(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardEntry_GetUser(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardEntryArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardEntryArray_GetNextUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_LeaderboardEntryArray_GetPreviousUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_LeaderboardEntryArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_LeaderboardEntryArray_GetTotalCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_LeaderboardEntryArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_LeaderboardEntryArray_HasPreviousPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfLeaderboardFilterType_ToString(LeaderboardFilterType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern LeaderboardFilterType ppfLeaderboardFilterType_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfLeaderboardStartAt_ToString(LeaderboardStartAt value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern LeaderboardStartAt ppfLeaderboardStartAt_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_LeaderboardUpdateStatus_GetDidUpdate(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_LeaderboardUpdateStatus_GetUpdatedChallengeId(IntPtr obj, uint index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_LeaderboardUpdateStatus_GetUpdatedChallengeIdsSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_MatchmakingAdminSnapshotCandidate_GetCanMatch(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_MatchmakingAdminSnapshotCandidate_GetMyTotalScore(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_MatchmakingAdminSnapshotCandidate_GetTheirCurrentThreshold(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingAdminSnapshotCandidateArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_MatchmakingAdminSnapshotCandidateArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_MatchmakingAdminSnapshotCandidateArray_GetTotalCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingAdminSnapshot_GetCandidates(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_MatchmakingAdminSnapshot_GetMyCurrentThreshold(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingEnqueueResult_GetAdminSnapshot(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingEnqueueResult_GetAverageWait(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingEnqueueResult_GetMatchesInLastHourCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingEnqueueResult_GetMaxExpectedWait(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingEnqueueResult_GetRecentMatchPercentage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingEnqueueResult_GetPool(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfRoomJoinability_ToString(RoomJoinability value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RoomJoinability ppfRoomJoinability_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfRoomJoinPolicy_ToString(RoomJoinPolicy value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RoomJoinPolicy ppfRoomJoinPolicy_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfRoomType_ToString(RoomType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RoomType ppfRoomType_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Room_GetDataStore(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Room_GetOwner(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Room_GetName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Room_GetUsers(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Room_GetDescription(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_Room_GetIsMembershipLocked(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RoomJoinPolicy ppf_Room_GetJoinPolicy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RoomJoinability ppf_Room_GetJoinability(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_Room_GetMaxUsers(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RoomType ppf_Room_GetType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_Room_GetPlayerNumber(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingRoom_GetPingTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingRoom_GetRoom(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_MatchmakingRoom_HasPingTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingRoomArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_MatchmakingRoomArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_MatchmakingRoomArray_GetTotalCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingBrowseResult_GetEnqueueResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingBrowseResult_GetRooms(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingEnqueueResultAndRoom_GetMatchmakingEnqueueResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingEnqueueResultAndRoom_GetRoom(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_MatchmakingOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_Destroy(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_SetCreateRoomDataStoreString(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_ClearCreateRoomDataStore(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_SetCreateRoomJoinPolicy(IntPtr handle, RoomJoinPolicy value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_SetCreateRoomMaxUsers(IntPtr handle, uint value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_ClearEnqueueAdditionalUsers(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_SetEnqueueDataSettingsInt(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string key, int value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_SetEnqueueDataSettingsDouble(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string key, double value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_SetEnqueueDataSettingsString(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_ClearEnqueueDataSettings(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_SetEnqueueIsDebug(IntPtr handle, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_MatchmakingOptions_SetEnqueueQueryKey(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingStats_GetDrawCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingStats_GetLossCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingStats_GetSkillLevel(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_MatchmakingStats_GetSkillMean(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_MatchmakingStats_GetSkillStandardDeviation(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern uint ppf_MatchmakingStats_GetWinCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_UserAndRoom_GetUser(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_UserAndRoom_GetRoom(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_UserAndRoomArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_UserAndRoomArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_UserAndRoomArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_UserAndRoomArray_GetNextPageParam(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcJoinRoomResult_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcJoinRoomResult_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcJoinRoomResult_GetErrorCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcJoinRoomResult_GetElapsed(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcJoinRoomType ppf_RtcJoinRoomResult_GetJoinType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcLeaveRoomResult_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcRoomStats_GetTotalDuration(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcRoomStats_GetUserCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRoomStats_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserJoinInfo_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserJoinInfo_GetUserExtra(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcUserJoinInfo_GetElapsed(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserJoinInfo_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserLeaveInfo_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcUserLeaveReasonType ppf_RtcUserLeaveInfo_GetOfflineReason(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserLeaveInfo_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcRoomWarn_GetCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRoomWarn_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcRoomError_GetCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRoomError_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcMuteInfo_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcMuteState ppf_RtcMuteInfo_GetMuteState(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcMediaDeviceChangeInfo_GetDeviceId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcMediaDeviceType ppf_RtcMediaDeviceChangeInfo_GetDeviceType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcMediaDeviceState ppf_RtcMediaDeviceChangeInfo_GetDeviceState(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcMediaDeviceError ppf_RtcMediaDeviceChangeInfo_GetDeviceError(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcAudioPropertyInfo_GetVolume(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcStreamIndex ppf_RtcLocalAudioPropertiesInfo_GetStreamIndex(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcLocalAudioPropertiesInfo_GetAudioPropertyInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcLocalAudioPropertiesReport_GetAudioPropertiesInfos(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_RtcLocalAudioPropertiesReport_GetAudioPropertiesInfosSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRemoteStreamKey_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRemoteStreamKey_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcStreamIndex ppf_RtcRemoteStreamKey_GetStreamIndex(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRemoteAudioPropertiesInfo_GetStreamKey(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRemoteAudioPropertiesInfo_GetAudioPropertiesInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRemoteAudioPropertiesReport_GetAudioPropertiesInfos(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_RtcRemoteAudioPropertiesReport_GetAudioPropertiesInfosSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcRemoteAudioPropertiesReport_GetTotalRemoteVolume(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRoomMessageReceived_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRoomMessageReceived_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcRoomMessageReceived_GetMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcBinaryMessageReceived_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcBinaryMessageReceived_GetData(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcBinaryMessageReceived_GetLength(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcBinaryMessageReceived_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcStreamSyncInfo_GetStreamKey(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcSyncInfoStreamType ppf_RtcStreamSyncInfo_GetStreamType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcStreamSyncInfo_GetData(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcStreamSyncInfo_GetLength(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcStreamIndex ppf_RtcFirstLocalVideoFrameCapturedInfo_GetStreamIndex(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcFirstLocalVideoFrameCapturedInfo_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcStreamIndex ppf_RtcLocalVideoSizeChangeInfo_GetStreamIndex(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcLocalVideoSizeChangeInfo_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserPublishInfo_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcMediaStreamType ppf_RtcUserPublishInfo_GetMediaStreamType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserPublishInfo_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserUnPublishInfo_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcMediaStreamType ppf_RtcUserUnPublishInfo_GetMediaStreamType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcStreamRemoveReason ppf_RtcUserUnPublishInfo_GetReason(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserUnPublishInfo_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RoomArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_RoomArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RoomArray_GetTotalCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_RoomArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RoomArray_GetPageSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RoomArray_GetPageIndex(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserMessageReceived_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserMessageReceived_GetUserId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcUserMessageReceived_GetMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_RtcMessageSendResult_GetMessageId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RtcMessageSendResult_GetError(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcMessageSendResult_GetRoomId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_CloudStorage_StartNewBackup();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfPlatformGameInitializeResult_ToString(GameInitializeResult value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern GameInitializeResult ppfPlatformGameInitializeResult_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern GameInitializeResult ppf_PlatformGameInitialize_GetResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SendInvitesResult_GetInvites(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PresenceJoinIntent_GetDeeplinkMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PresenceJoinIntent_GetDestinationApiName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PresenceJoinIntent_GetLobbySessionId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PresenceJoinIntent_GetMatchSessionId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PresenceJoinIntent_GetExtra(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_RoomInviteNotification_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_RoomInviteNotification_GetRoomID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RoomInviteNotification_GetSenderID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_RoomInviteNotification_GetSentTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RoomInviteNotificationArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RoomInviteNotificationArray_GetNextUrl(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_RoomInviteNotificationArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RoomInviteNotificationArray_GetTotalCount(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_RoomInviteNotificationArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern Gender ppf_SportUserInfo_GetGender(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SportUserInfo_GetBirthday(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SportUserInfo_GetStature(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SportUserInfo_GetWeight(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SportUserInfo_GetSportLevel(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SportUserInfo_GetDailyDurationInMinutes(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SportUserInfo_GetDaysPerWeek(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern SportTarget ppf_SportUserInfo_GetSportTarget(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SportDailySummary_GetId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SportDailySummary_GetDate(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SportDailySummary_GetDurationInSeconds(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SportDailySummary_GetPlanDurationInMinutes(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_SportDailySummary_GetCalorie(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_SportDailySummary_GetPlanCalorie(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SportDailySummaryArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_SportDailySummaryArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SportSummary_GetDurationInSeconds(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern double ppf_SportSummary_GetCalorie(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SportSummary_GetStartTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SportSummary_GetEndTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_Purchase_GetExpirationTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_Purchase_GetGrantTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Purchase_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Purchase_GetSKU(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Purchase_GetIcon(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern AddonsType ppf_Purchase_GetAddonsType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Purchase_GetOuterId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern PeriodType ppf_Purchase_GetCurrentPeriodType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern PeriodType ppf_Purchase_GetNextPeriodType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_Purchase_GetNextPayTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern DiscountType ppf_Purchase_GetDiscountType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Purchase_GetOrderComment(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PurchaseArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_PurchaseArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_PurchaseArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PurchaseArray_GetNextPageParam(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetDescription(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetDetailDescription(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetPrice(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetCurrency(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetName(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetSKU(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetIcon(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern AddonsType ppf_Product_GetAddonsType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern PeriodType ppf_Product_GetPeriodType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern PeriodType ppf_Product_GetTrialPeriodUnit(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Product_GetTrialPeriodValue(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetOuterId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetOriginalPrice(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Product_GetGroupId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Product_GetLevel(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_Product_IsContinuous(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ProductArray_GetElement(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_ProductArray_GetSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_ProductArray_HasNextPage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ProductArray_GetNextPageParam(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PermissionResult_GetAuthorizedPermissions(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_PermissionResult_GetAuthorizedPermissionsSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PermissionResult_GetAccessToken(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PermissionResult_GetUserID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SubscriptionStatus_GetSKU(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SubscriptionStatus_GetOuterId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SubscriptionStatus_GetStartTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_SubscriptionStatus_GetEndTime(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern PeriodType ppf_SubscriptionStatus_GetPeriodType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern EntitlementStatus ppf_SubscriptionStatus_GetEntitlementStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern CancelReason ppf_SubscriptionStatus_GetCancelReason(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_SubscriptionStatus_GetIsFreeTrial(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SubscriptionStatus_GetNextPeriod(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_UserRelationResult_GetRelationsKey(IntPtr obj, int index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UserRelationType ppf_UserRelationResult_GetRelationsValue(IntPtr obj, int index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_UserRelationResult_GetRelationsSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SpeechError_GetMessage(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SpeechError_GetSessionId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_SpeechError_GetCode(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_OrgScopedID_GetID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RecordInfo_GetVideoPath(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RecordInfo_GetJobId(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RecordInfo_GetDurationInMilliSeconds(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RecordInfo_GetWidth(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_RecordInfo_GetHeight(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SessionMedia_GetImages(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_SessionMedia_GetImagesSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_SessionMedia_GetVideos(IntPtr obj, UIntPtr index);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern UIntPtr ppf_SessionMedia_GetVideosSize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetUser(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetString(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_Message_GetInt32(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern MessageType ppf_Message_GetType(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetError(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal static extern bool ppf_Message_IsError(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Message_GetRequestID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetUserArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetLaunchFriendRequestFlowResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetUserAndRoomArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetPermissionResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetApplicationVersion(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetUserRelationResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetSubscriptionStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetEntitlementCheckResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcJoinRoomResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcLeaveRoomResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcRoomStats(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcUserJoinInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcUserLeaveInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcRoomWarn(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcRoomError(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcMuteInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcAudioPlaybackDevice ppf_Message_GetRtcAudioPlaybackDevice(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcMediaDeviceChangeInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcLocalAudioPropertiesReport(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcRemoteAudioPropertiesReport(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcRoomMessageReceived(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcUserMessageReceived(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcBinaryMessageReceived(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcStreamSyncInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcFirstLocalVideoFrameCapturedInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcLocalVideoSizeChangeInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcMessageSendResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcUserPublishInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRtcUserUnPublishInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetMatchmakingAdminSnapshot(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetMatchmakingBrowseResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetMatchmakingBrowseCustomPageResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetMatchmakingEnqueueResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetMatchmakingEnqueueResultAndRoom(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetMatchmakingStats(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRoom(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRoomArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetPlatformGameInitialize(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern GameConnectionEvent ppf_Message_GetGameConnectionEvent(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern GameRequestFailedReason ppf_Message_GetGameRequestFailedReason(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetApplicationInviteArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetSendInvitesResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetDestinationArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetPresenceJoinIntent(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRoomInviteNotificationArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetLeaderboardArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetLeaderboardUpdateStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetLeaderboardEntryArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAchievementDefinitionArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAchievementProgressArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAchievementUpdate(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetChallenge(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetChallengeArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetChallengeEntryArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetPurchaseArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetProductArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetPurchase(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetSportUserInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetSportDailySummaryArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetSportSummary(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAssetDetails(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAssetDetailsArray(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAssetFileDeleteResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAssetFileDownloadCancelResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAssetFileDownloadResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAssetFileDownloadUpdate(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAssetStatus(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAssetFileDeleteForSafety(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetAsrResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetSpeechError(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetDetectSensitiveResult(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetOrgScopedID(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetCaptureInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetRecordInfo(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_Message_GetSessionMedia(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern PlatformInitializeResult ppf_PcInitWrapper([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string appId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string configPath, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string logPath);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_PcInitAsynchronousWrapper([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string appId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string configJson, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string logPath);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_PcUnInitialize();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RegisterFunctions();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern int ppf_GetLoaderVersion();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_PresenceOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_PresenceOptions_Destroy(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_PresenceOptions_SetDestinationApiName(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_PresenceOptions_SetIsJoinable(IntPtr handle, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_PresenceOptions_SetLobbySessionId(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_PresenceOptions_SetMatchSessionId(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_PresenceOptions_SetExtra(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Achievements_AddCount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string name, long count, IntPtr extra_data, uint extra_data_length);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Achievements_AddFields([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string fields, IntPtr extra_data, uint extra_data_length);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Achievements_GetAllDefinitions(int pageIdx, int pageSize);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Achievements_GetAllProgress(int pageIdx, int pageSize);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Achievements_GetDefinitionsByName(IntPtr[] names, int count);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Achievements_GetProgressByName(IntPtr[] names, int count);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Achievements_Unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string name, IntPtr extra_data, uint extra_data_length);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Application_LaunchOtherApp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string packageName, IntPtr deeplink_options);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Application_LaunchOtherAppByAppID([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string appID, IntPtr deeplink_options);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Application_LaunchOtherAppByPresence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string appID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string packageName, IntPtr options);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Application_LaunchOtherAppByMessage(IntPtr options);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Application_GetVersion();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Application_LaunchStore();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_DeleteById(ulong assetFileID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_DeleteByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string assetFileName);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_DownloadById(ulong assetFileID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_DownloadByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string assetFileName);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_DownloadCancelById(ulong assetFileID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_DownloadCancelByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string assetFileName);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_GetList();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_GetNextAssetDetailsArrayPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string @params);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_StatusById(ulong assetFileID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_AssetFile_StatusByName([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string assetFileName);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_Invites(ulong challengeID, IntPtr[] userIDs, uint userIDLength);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_Get(ulong challengeID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_GetEntries(ulong challengeID, LeaderboardFilterType filter, LeaderboardStartAt startAt, int pageIdx, int pageSize);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_GetEntriesAfterRank(ulong challengeID, ulong afterRank, int pageIdx, int pageSize);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_GetEntriesByIds(ulong challengeID, LeaderboardStartAt startAt, IntPtr[] userIDs, uint userIDLength, int pageIdx, int pageSize);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_GetList(IntPtr challengeOptions, int pageIdx, int pageSize);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_Join(ulong challengeID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_Leave(ulong challengeID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Challenges_LaunchInvitableUserFlow(ulong challengeID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Compliance_DetectSensitive(DetectSensitiveScene scene, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string content);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Highlight_CaptureScreen();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Highlight_ListMedia([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string sessionId);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Highlight_SaveMedia([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string jobId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string sessionId);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Highlight_ShareMedia([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string jobId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string sessionId);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Highlight_StartRecord();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Highlight_StartSession();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Highlight_StopRecord();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_ConsumePurchase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string sku);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_GetNextProductArrayPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string nextPageParam);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_GetNextPurchaseArrayPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string nextPageParam);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_GetProductsBySKU(IntPtr[] skus, int size);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_GetViewerPurchases();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_LaunchCheckoutFlow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string sku, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string price, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string currency);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_LaunchCheckoutFlowV2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string sku, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string price, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string currency, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string outerId);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_LaunchCheckoutFlowV3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string sku, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string price, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string currency, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string outerId, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string orderComment);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_IAP_GetSubscriptionStatus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string sku);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_Get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string leaderboardName);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_GetEntries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string leaderboardName, int pageSize, int pageIdx, LeaderboardFilterType filter, LeaderboardStartAt startAt);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_GetEntriesAfterRank([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string leaderboardName, int pageSize, int pageIdx, ulong afterRank);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_GetEntriesByIds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string leaderboardName, int pageSize, int pageIdx, LeaderboardStartAt startAt, IntPtr[] userIDs, uint userIDLength);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_GetNextEntries(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_GetNextLeaderboardArrayPage(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_GetPreviousEntries(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_WriteEntry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string leaderboardName, long score, IntPtr extraData, uint extraDataLength, bool forceUpdate);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Leaderboard_WriteEntryWithSupplementaryMetric([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string leaderboardName, long score, long supplementaryMetric, IntPtr extraData, uint extraDataLength, bool forceUpdate);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_Browse2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string pool, IntPtr matchmakingOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_Browse2CustomPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string pool, IntPtr matchmakingOptions, int pageIndex, int pageSize);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_Cancel2();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_CreateAndEnqueueRoom2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string pool, IntPtr matchmakingOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_Enqueue2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string pool, IntPtr matchmakingOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_GetAdminSnapshot();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_GetStats([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string pool, uint maxLevel, MatchmakingStatApproach approach);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_ReportResultInsecure(ulong roomID, IntPtr data, uint numItems);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_StartMatch(ulong roomID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Matchmaking_CrashTest();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Notification_GetNextRoomInviteNotificationArrayPage(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Notification_GetRoomInvites(int pageIdx, int pageSize);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Notification_MarkAsRead(ulong notificationID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ShareMediaOptions_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_ShareMediaOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ShareMediaOptions_SetShareMediaType(IntPtr obj, ShareMediaType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ShareMediaOptions_SetVideoPath(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ShareMediaOptions_SetVideoThumbPath(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ShareMediaOptions_AddImagePath(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ShareMediaOptions_ClearImagePaths(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_ShareMediaOptions_SetShareAppType(IntPtr obj, ShareAppType value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_Clear();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_GetInvitableUsers(IntPtr options);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_GetNextApplicationInviteArrayPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string @params);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_GetSentInvites();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_SendInvites(IntPtr[] userIDs, uint userIDLength);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_SendCustomInvites([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string msg, IntPtr[] userIDs, uint userIDLength);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_Set(IntPtr presenceOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_SetDestination([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string api_name);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_SetIsJoinable(bool is_joinable);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_SetLobbySession([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string id);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_SetMatchSession([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string id);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_SetExtra([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string extra);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_GetDestinations();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_GetNextDestinationArrayPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string @params);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_ShareMedia(IntPtr shareMediaOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Presence_LaunchInvitePanel();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppfRoomMembershipLockStatus_ToString(RoomMembershipLockStatus value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RoomMembershipLockStatus ppfRoomMembershipLockStatus_FromString([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string str);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RoomOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_Destroy(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetDataStoreString(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_ClearDataStore(IntPtr handle);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetExcludeRecentlyMet(IntPtr handle, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetMaxUserResults(IntPtr handle, uint value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetOrdering(IntPtr handle, UserOrdering value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetRecentlyMetTimeWindow(IntPtr handle, long value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetRoomId(IntPtr handle, ulong value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetTurnOffUpdates(IntPtr handle, bool value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetName(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string name);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RoomOptions_SetPassword(IntPtr handle, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string password);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_CreateAndJoinPrivate2(RoomJoinPolicy joinPolicy, uint maxUsers, IntPtr roomOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_Get(ulong roomID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_GetCurrent();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_GetCurrentForUser([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_GetInvitableUsers2(IntPtr roomOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_GetModeratedRooms(int page_idx, int page_size);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_JoinNamed(RoomJoinPolicy joinPolicy, bool createIfNotExist, uint maxUsers, IntPtr roomOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_GetNamedRooms(int page_idx, int page_size);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_InviteUser(ulong roomID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string inviteToken);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_Join2(ulong roomID, IntPtr roomOptions);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_KickUser(ulong roomID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userID, int kickDurationSeconds);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_LaunchInvitableUserFlow(ulong roomID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_Leave(ulong roomID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_SetDescription(ulong roomID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string description);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_UpdateDataStore(ulong roomID, IntPtr data, uint numItems);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_UpdateMembershipLockStatus(ulong roomID, RoomMembershipLockStatus membershipLockStatus);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_UpdateOwner(ulong roomID, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Room_UpdatePrivateRoomJoinPolicy(ulong roomID, RoomJoinPolicy newJoinPolicy);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcGetTokenOptions_Destroy(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcGetTokenOptions_Create();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcGetTokenOptions_SetUserId(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcGetTokenOptions_SetRoomId(IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcGetTokenOptions_SetTtl(IntPtr obj, int value);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcGetTokenOptions_ClearPrivileges(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern void ppf_RtcGetTokenOptions_SetPrivileges(IntPtr obj, RtcPrivilege k, int v);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Rtc_GetToken(IntPtr options);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Sport_GetDailySummary(long beginTime, long endTime);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Sport_GetSummary(long beginTime, long endTime);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_Sport_GetUserInfo();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_Get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetAccessToken();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetIdToken();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetLoggedInUser();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetLoggedInUserFriends();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetNextUserArrayPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string param);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_LaunchFriendRequestFlow([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetLoggedInUserFriendsAndRooms();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetNextUserAndRoomArrayPage([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string param);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetAuthorizedPermissions();

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_RequestUserPermissions(IntPtr[] permissions, int size);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetRelations(IntPtr[] userIds, int size);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_EntitlementCheck(bool killApp);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern ulong ppf_User_GetOrgScopedID([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Pico.Platform.UTF8Marshaller")] string userID);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcAudioSampleRate ppf_RtcAudioFrame_GetSampleRate(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern RtcAudioChannel ppf_RtcAudioFrame_GetChannel(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_RtcAudioFrame_GetTimeStampInUs(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern IntPtr ppf_RtcAudioFrame_GetData(IntPtr obj);

			[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
			internal static extern long ppf_RtcAudioFrame_GetDataSize(IntPtr obj);
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate int RtcProcessAudioFrameFunction(IntPtr audioFrameHandle);

		public static IntPtr ppf_PopMessage()
		{
			return (IntPtr)0;
		}

		public static void ppf_FreeMessage(IntPtr obj)
		{
		}

		public static string ppfAchievementType_ToString(AchievementType value)
		{
			return null;
		}

		public static AchievementType ppfAchievementType_FromString(string str)
		{
			return default(AchievementType);
		}

		public static string ppfAchievementWritePolicy_ToString(AchievementWritePolicy value)
		{
			return null;
		}

		public static AchievementWritePolicy ppfAchievementWritePolicy_FromString(string str)
		{
			return default(AchievementWritePolicy);
		}

		public static string ppfKeyValuePairType_ToString(KVPairType value)
		{
			return null;
		}

		public static KVPairType ppfKeyValuePairType_FromString(string str)
		{
			return default(KVPairType);
		}

		public static string ppfMatchmakingCriterionImportance_ToString(MatchmakingCriterionImportance value)
		{
			return null;
		}

		public static MatchmakingCriterionImportance ppfMatchmakingCriterionImportance_FromString(string str)
		{
			return default(MatchmakingCriterionImportance);
		}

		public static ulong ppf_AchievementDefinition_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_AchievementDefinition_GetName(IntPtr obj)
		{
			return null;
		}

		public static uint ppf_AchievementDefinition_GetBitfieldLength(IntPtr obj)
		{
			return 0u;
		}

		public static long ppf_AchievementDefinition_GetTarget(IntPtr obj)
		{
			return 0L;
		}

		public static AchievementType ppf_AchievementDefinition_GetType(IntPtr obj)
		{
			return default(AchievementType);
		}

		public static AchievementWritePolicy ppf_AchievementDefinition_GetWritePolicy(IntPtr obj)
		{
			return default(AchievementWritePolicy);
		}

		public static bool ppf_AchievementDefinition_IsArchived(IntPtr obj)
		{
			return false;
		}

		public static bool ppf_AchievementDefinition_IsSecret(IntPtr obj)
		{
			return false;
		}

		public static string ppf_AchievementDefinition_GetTitle(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AchievementDefinition_GetDescription(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AchievementDefinition_GetUnlockedDescription(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AchievementDefinition_GetLockedImageURL(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AchievementDefinition_GetUnlockedImageURL(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_AchievementDefinitionArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_AchievementDefinitionArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_AchievementDefinitionArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static UIntPtr ppf_AchievementDefinitionArray_GetTotalSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_AchievementDefinitionArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static ulong ppf_AchievementProgress_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_AchievementProgress_GetBitfield(IntPtr obj)
		{
			return null;
		}

		public static long ppf_AchievementProgress_GetCount(IntPtr obj)
		{
			return 0L;
		}

		public static bool ppf_AchievementProgress_GetIsUnlocked(IntPtr obj)
		{
			return false;
		}

		public static string ppf_AchievementProgress_GetName(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_AchievementProgress_GetUnlockTime(IntPtr obj)
		{
			return 0uL;
		}

		public static IntPtr ppf_AchievementProgress_GetExtraData(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static uint ppf_AchievementProgress_GetExtraDataLength(IntPtr obj)
		{
			return 0u;
		}

		public static IntPtr ppf_AchievementProgressArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_AchievementProgressArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_AchievementProgressArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static UIntPtr ppf_AchievementProgressArray_GetTotalSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_AchievementProgressArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static bool ppf_AchievementUpdate_GetJustUnlocked(IntPtr obj)
		{
			return false;
		}

		public static string ppf_AchievementUpdate_GetName(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_ApplicationByMessageOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_ApplicationByMessageOptions_Destroy(IntPtr handle)
		{
		}

		public static void ppf_ApplicationByMessageOptions_SetMessageData(IntPtr handle, string value)
		{
		}

		public static IntPtr ppf_ApplicationByPresenceOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_ApplicationByPresenceOptions_Destroy(IntPtr handle)
		{
		}

		public static void ppf_ApplicationByPresenceOptions_SetDeeplinkMessage(IntPtr handle, string value)
		{
		}

		public static void ppf_ApplicationByPresenceOptions_SetDestinationApiName(IntPtr handle, string value)
		{
		}

		public static void ppf_ApplicationByPresenceOptions_SetLobbySessionId(IntPtr handle, string value)
		{
		}

		public static void ppf_ApplicationByPresenceOptions_SetMatchSessionId(IntPtr handle, string value)
		{
		}

		public static void ppf_ApplicationByPresenceOptions_SetTrackingId(IntPtr handle, string value)
		{
		}

		public static void ppf_ApplicationByPresenceOptions_SetExtra(IntPtr handle, string value)
		{
		}

		public static string ppf_Destination_GetApiName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Destination_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Destination_GetDisplayName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetDisplayName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetImageUrl(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetID(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetInviteToken(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetSmallImageUrl(IntPtr obj)
		{
			return null;
		}

		public static UserPresenceStatus ppf_User_GetPresenceStatus(IntPtr obj)
		{
			return default(UserPresenceStatus);
		}

		public static Gender ppf_User_GetGender(IntPtr obj)
		{
			return default(Gender);
		}

		public static string ppf_User_GetPresence(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetPresenceDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetPresenceDestinationApiName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetPresenceLobbySessionId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetPresenceMatchSessionId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetPresencePackage(IntPtr obj)
		{
			return null;
		}

		public static string ppf_User_GetPresenceExtra(IntPtr obj)
		{
			return null;
		}

		public static bool ppf_User_GetPresenceIsJoinable(IntPtr obj)
		{
			return false;
		}

		public static string ppf_User_GetStoreRegion(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_ApplicationInvite_GetDestination(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_ApplicationInvite_GetRecipient(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static ulong ppf_ApplicationInvite_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static bool ppf_ApplicationInvite_GetIsActive(IntPtr obj)
		{
			return false;
		}

		public static string ppf_ApplicationInvite_GetLobbySessionId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_ApplicationInvite_GetMatchSessionId(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_ApplicationInviteArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_ApplicationInviteArray_GetNextPageParam(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_ApplicationInviteArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_ApplicationInviteArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static IntPtr ppf_ApplicationOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_ApplicationOptions_Destroy(IntPtr handle)
		{
		}

		public static void ppf_ApplicationOptions_SetDeeplinkMessage(IntPtr handle, string value)
		{
		}

		public static long ppf_ApplicationVersion_GetCurrentCode(IntPtr obj)
		{
			return 0L;
		}

		public static string ppf_ApplicationVersion_GetCurrentName(IntPtr obj)
		{
			return null;
		}

		public static long ppf_ApplicationVersion_GetLatestCode(IntPtr obj)
		{
			return 0L;
		}

		public static string ppf_ApplicationVersion_GetLatestName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AsrResult_GetText(IntPtr obj)
		{
			return null;
		}

		public static bool ppf_AsrResult_GetIsFinalResult(IntPtr obj)
		{
			return false;
		}

		public static string ppf_AsrResult_GetSessionId(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_AssetDetails_GetAssetId(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_AssetDetails_GetAssetType(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetDownloadStatus(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetFilepath(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetIapStatus(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetMetadata(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetFilename(IntPtr obj)
		{
			return null;
		}

		public static int ppf_AssetDetails_GetVersion(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_AssetDetails_GetIapSku(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetIapName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetIapPrice(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetIapCurrency(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetIapDescription(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetDetails_GetIapIcon(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_AssetDetailsArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_AssetDetailsArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_AssetDetailsArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static string ppf_AssetDetailsArray_GetNextPageParam(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_AssetFileDeleteForSafety_GetAssetId(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_AssetFileDeleteForSafety_GetReason(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_AssetFileDeleteResult_GetAssetId(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_AssetFileDeleteResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		public static bool ppf_AssetFileDeleteResult_GetSuccess(IntPtr obj)
		{
			return false;
		}

		public static ulong ppf_AssetFileDownloadCancelResult_GetAssetId(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_AssetFileDownloadCancelResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		public static bool ppf_AssetFileDownloadCancelResult_GetSuccess(IntPtr obj)
		{
			return false;
		}

		public static ulong ppf_AssetFileDownloadResult_GetAssetId(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_AssetFileDownloadResult_GetFilepath(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_AssetFileDownloadUpdate_GetAssetId(IntPtr obj)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFileDownloadUpdate_GetBytesTotal(IntPtr obj)
		{
			return 0uL;
		}

		public static long ppf_AssetFileDownloadUpdate_GetBytesTransferred(IntPtr obj)
		{
			return 0L;
		}

		public static AssetFileDownloadCompleteStatus ppf_AssetFileDownloadUpdate_GetCompleteStatus(IntPtr obj)
		{
			return default(AssetFileDownloadCompleteStatus);
		}

		public static ulong ppf_AssetStatus_GetAssetId(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_AssetStatus_GetFilename(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetStatus_GetFilepath(IntPtr obj)
		{
			return null;
		}

		public static string ppf_AssetStatus_GetDownloadStatus(IntPtr obj)
		{
			return null;
		}

		public static string ppf_CaptureInfo_GetImagePath(IntPtr obj)
		{
			return null;
		}

		public static string ppf_CaptureInfo_GetJobId(IntPtr obj)
		{
			return null;
		}

		public static string ppfChallengeCreationType_ToString(ChallengeCreationType value)
		{
			return null;
		}

		public static ChallengeCreationType ppfChallengeCreationType_FromString(string str)
		{
			return default(ChallengeCreationType);
		}

		public static string ppfChallengeVisibility_ToString(ChallengeVisibility value)
		{
			return null;
		}

		public static ChallengeVisibility ppfChallengeVisibility_FromString(string str)
		{
			return default(ChallengeVisibility);
		}

		public static IntPtr ppf_Leaderboard_GetDestination(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static string ppf_Leaderboard_GetApiName(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_Leaderboard_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static IntPtr ppf_UserArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_UserArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_UserArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static string ppf_UserArray_GetNextPageParam(IntPtr obj)
		{
			return null;
		}

		public static ChallengeCreationType ppf_Challenge_GetCreationType(IntPtr obj)
		{
			return default(ChallengeCreationType);
		}

		public static IntPtr ppf_Challenge_GetInvitedUsers(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Challenge_GetLeaderboard(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Challenge_GetParticipants(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static string ppf_Challenge_GetTitle(IntPtr obj)
		{
			return null;
		}

		public static ChallengeVisibility ppf_Challenge_GetVisibility(IntPtr obj)
		{
			return default(ChallengeVisibility);
		}

		public static ulong ppf_Challenge_GetEndDate(IntPtr obj)
		{
			return 0uL;
		}

		public static ulong ppf_Challenge_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static ulong ppf_Challenge_GetStartDate(IntPtr obj)
		{
			return 0uL;
		}

		public static IntPtr ppf_ChallengeArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_ChallengeArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		public static string ppf_ChallengeArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_ChallengeArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static ulong ppf_ChallengeArray_GetTotalCount(IntPtr obj)
		{
			return 0uL;
		}

		public static bool ppf_ChallengeArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static bool ppf_ChallengeArray_HasPreviousPage(IntPtr obj)
		{
			return false;
		}

		public static string ppf_ChallengeEntry_GetDisplayScore(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_ChallengeEntry_GetExtraData(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static uint ppf_ChallengeEntry_GetExtraDataLength(IntPtr obj)
		{
			return 0u;
		}

		public static ulong ppf_ChallengeEntry_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static int ppf_ChallengeEntry_GetRank(IntPtr obj)
		{
			return 0;
		}

		public static long ppf_ChallengeEntry_GetScore(IntPtr obj)
		{
			return 0L;
		}

		public static ulong ppf_ChallengeEntry_GetTimestamp(IntPtr obj)
		{
			return 0uL;
		}

		public static IntPtr ppf_ChallengeEntry_GetUser(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_ChallengeEntryArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_ChallengeEntryArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		public static string ppf_ChallengeEntryArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_ChallengeEntryArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static ulong ppf_ChallengeEntryArray_GetTotalCount(IntPtr obj)
		{
			return 0uL;
		}

		public static bool ppf_ChallengeEntryArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static bool ppf_ChallengeEntryArray_HasPreviousPage(IntPtr obj)
		{
			return false;
		}

		public static string ppfChallengeViewerFilter_ToString(ChallengeViewerFilter value)
		{
			return null;
		}

		public static ChallengeViewerFilter ppfChallengeViewerFilter_FromString(string str)
		{
			return default(ChallengeViewerFilter);
		}

		public static IntPtr ppf_ChallengeOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_ChallengeOptions_Destroy(IntPtr handle)
		{
		}

		public static void ppf_ChallengeOptions_SetEndDate(IntPtr handle, ulong value)
		{
		}

		public static void ppf_ChallengeOptions_SetIncludeActiveChallenges(IntPtr handle, bool value)
		{
		}

		public static void ppf_ChallengeOptions_SetIncludeFutureChallenges(IntPtr handle, bool value)
		{
		}

		public static void ppf_ChallengeOptions_SetIncludePastChallenges(IntPtr handle, bool value)
		{
		}

		public static void ppf_ChallengeOptions_SetLeaderboardName(IntPtr handle, string value)
		{
		}

		public static void ppf_ChallengeOptions_SetStartDate(IntPtr handle, ulong value)
		{
		}

		public static void ppf_ChallengeOptions_SetTitle(IntPtr handle, string value)
		{
		}

		public static void ppf_ChallengeOptions_SetViewerFilter(IntPtr handle, ChallengeViewerFilter value)
		{
		}

		public static void ppf_ChallengeOptions_SetVisibility(IntPtr handle, ChallengeVisibility value)
		{
		}

		public static uint ppf_DataStore_Contains(IntPtr obj, string key)
		{
			return 0u;
		}

		public static string ppf_DataStore_GetKey(IntPtr obj, int index)
		{
			return null;
		}

		public static UIntPtr ppf_DataStore_GetNumKeys(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static string ppf_DataStore_GetValue(IntPtr obj, string key)
		{
			return null;
		}

		public static IntPtr ppf_DestinationArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_DestinationArray_GetNextPageParam(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_DestinationArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_DestinationArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static string ppf_DetectSensitiveResult_GetFilteredText(IntPtr obj)
		{
			return null;
		}

		public static SensitiveProposal ppf_DetectSensitiveResult_GetProposal(IntPtr obj)
		{
			return default(SensitiveProposal);
		}

		public static bool ppf_EntitlementCheckResult_GetHasEntitlement(IntPtr obj)
		{
			return false;
		}

		public static int ppf_EntitlementCheckResult_GetStatusCode(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_EntitlementCheckResult_GetStatusMessage(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Error_GetMessage(IntPtr obj)
		{
			return null;
		}

		public static int ppf_Error_GetCode(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_LaunchDetails_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		public static string ppf_LaunchDetails_GetDestinationApiName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_LaunchDetails_GetLobbySessionID(IntPtr obj)
		{
			return null;
		}

		public static string ppf_LaunchDetails_GetMatchSessionID(IntPtr obj)
		{
			return null;
		}

		public static string ppf_LaunchDetails_GetExtra(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_LaunchDetails_GetRoomID(IntPtr obj)
		{
			return 0uL;
		}

		public static ulong ppf_LaunchDetails_GetChallengeID(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_LaunchDetails_GetTrackingID(IntPtr obj)
		{
			return null;
		}

		public static LaunchType ppf_LaunchDetails_GetLaunchType(IntPtr obj)
		{
			return default(LaunchType);
		}

		public static string ppf_LaunchDetails_GetClientAction(IntPtr obj)
		{
			return null;
		}

		public static string ppf_SystemInfo_GetROMVersion(IntPtr obj)
		{
			return null;
		}

		public static string ppf_SystemInfo_GetLocale(IntPtr obj)
		{
			return null;
		}

		public static string ppf_SystemInfo_GetProductName(IntPtr obj)
		{
			return null;
		}

		public static bool ppf_SystemInfo_GetIsCnDevice(IntPtr obj)
		{
			return false;
		}

		public static string ppf_SystemInfo_GetMatrixVersionName(IntPtr obj)
		{
			return null;
		}

		public static long ppf_SystemInfo_GetMatrixVersionCode(IntPtr obj)
		{
			return 0L;
		}

		public static IntPtr ppf_ApplicationLifecycle_GetLaunchDetails()
		{
			return (IntPtr)0;
		}

		public static void ppf_ApplicationLifecycle_LogDeeplinkResult(string trackingID, LaunchResult result)
		{
		}

		public static IntPtr ppf_Application_GetSystemInfo()
		{
			return (IntPtr)0;
		}

		public static void ppf_Packet_Free(IntPtr obj)
		{
		}

		public static IntPtr ppf_Packet_GetBytes(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static string ppf_Packet_GetSenderID(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_Packet_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static IntPtr ppf_Net_ReadPacket()
		{
			return (IntPtr)0;
		}

		public static bool ppf_Net_SendPacket(string userID, UIntPtr length, IntPtr bytes)
		{
			return false;
		}

		public static bool ppf_Net_SendPacket2(string userID, UIntPtr length, IntPtr bytes, bool reliable)
		{
			return false;
		}

		public static bool ppf_Net_SendPacketToCurrentRoom(UIntPtr length, IntPtr bytes)
		{
			return false;
		}

		public static bool ppf_Net_SendPacketToCurrentRoom2(UIntPtr length, IntPtr bytes, bool reliable)
		{
			return false;
		}

		public static void ppf_RtcAudioPropertyOptions_Destroy(IntPtr obj)
		{
		}

		public static IntPtr ppf_RtcAudioPropertyOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_RtcAudioPropertyOptions_SetInterval(IntPtr obj, int value)
		{
		}

		public static void ppf_RtcStreamSyncInfoOptions_Destroy(IntPtr obj)
		{
		}

		public static IntPtr ppf_RtcStreamSyncInfoOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_RtcStreamSyncInfoOptions_SetStreamIndex(IntPtr obj, RtcStreamIndex value)
		{
		}

		public static void ppf_RtcStreamSyncInfoOptions_SetRepeatCount(IntPtr obj, int value)
		{
		}

		public static void ppf_RtcStreamSyncInfoOptions_SetStreamType(IntPtr obj, RtcSyncInfoStreamType value)
		{
		}

		public static void ppf_RtcRoomOptions_Destroy(IntPtr obj)
		{
		}

		public static IntPtr ppf_RtcRoomOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_RtcRoomOptions_SetRoomProfileType(IntPtr obj, RtcRoomProfileType value)
		{
		}

		public static void ppf_RtcRoomOptions_SetIsAutoSubscribeAudio(IntPtr obj, bool value)
		{
		}

		public static void ppf_RtcRoomOptions_SetRoomId(IntPtr obj, string value)
		{
		}

		public static void ppf_RtcRoomOptions_SetUserId(IntPtr obj, string value)
		{
		}

		public static void ppf_RtcRoomOptions_SetUserExtra(IntPtr obj, string value)
		{
		}

		public static void ppf_RtcRoomOptions_SetToken(IntPtr obj, string value)
		{
		}

		public static void ppf_RtcAudioFrameOptions_Destroy(IntPtr obj)
		{
		}

		public static IntPtr ppf_RtcAudioFrameOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_RtcAudioFrameOptions_SetSampleRate(IntPtr obj, RtcAudioSampleRate value)
		{
		}

		public static void ppf_RtcAudioFrameOptions_SetChannel(IntPtr obj, RtcAudioChannel value)
		{
		}

		public static void ppf_RtcAudioFrameOptions_SetTimeStampInUs(IntPtr obj, long value)
		{
		}

		public static void ppf_RtcAudioFrameOptions_SetData(IntPtr obj, IntPtr value)
		{
		}

		public static void ppf_RtcAudioFrameOptions_SetDataSize(IntPtr obj, long value)
		{
		}

		public static void ppf_RtcAudioFrameOptions_SetDeepCopy(IntPtr obj, bool value)
		{
		}

		public static RtcEngineInitResult ppf_Rtc_InitRtcEngine()
		{
			return default(RtcEngineInitResult);
		}

		public static void ppf_Rtc_UnInitRtcEngine()
		{
		}

		public static int ppf_Rtc_JoinRoom(IntPtr roomOptions)
		{
			return 0;
		}

		public static int ppf_Rtc_LeaveRoom(string roomId)
		{
			return 0;
		}

		public static void ppf_Rtc_DestroyRoom(string roomId)
		{
		}

		public static void ppf_Rtc_PublishRoom(string roomId)
		{
		}

		public static void ppf_Rtc_UnPublishRoom(string roomId)
		{
		}

		public static void ppf_Rtc_UpdateToken(string roomId, string token)
		{
		}

		public static void ppf_Rtc_EnableAudioPropertiesReport(IntPtr config)
		{
		}

		public static void ppf_Rtc_MuteLocalAudio(RtcMuteState muteState)
		{
		}

		public static void ppf_Rtc_RoomPauseAllSubscribedStream(string roomId, RtcPauseResumeMediaType mediaType)
		{
		}

		public static void ppf_Rtc_RoomResumeAllSubscribedStream(string roomId, RtcPauseResumeMediaType mediaType)
		{
		}

		public static void ppf_Rtc_SetAudioPlaybackDevice(RtcAudioPlaybackDevice device)
		{
		}

		public static void ppf_Rtc_SetAudioScenario(RtcAudioScenarioType scenario)
		{
		}

		public static void ppf_Rtc_SetCaptureVolume(RtcStreamIndex index, int volume)
		{
		}

		public static void ppf_Rtc_SetEarMonitorMode(RtcEarMonitorMode earMonitorMode)
		{
		}

		public static void ppf_Rtc_SetEarMonitorVolume(int volume)
		{
		}

		public static void ppf_Rtc_SetPlaybackVolume(int volume)
		{
		}

		public static void ppf_Rtc_StartAudioCapture()
		{
		}

		public static void ppf_Rtc_StopAudioCapture()
		{
		}

		public static void ppf_Rtc_RoomPublishStream(string roomId, RtcMediaStreamType streamType)
		{
		}

		public static void ppf_Rtc_RoomSetRemoteAudioPlaybackVolume(string roomId, string userId, int volume)
		{
		}

		public static void ppf_Rtc_RoomSubscribeStream(string roomId, string userId, RtcMediaStreamType mediaType)
		{
		}

		public static void ppf_Rtc_RoomUnPublishStream(string roomId, RtcMediaStreamType streamType)
		{
		}

		public static void ppf_Rtc_RoomUnsubscribeStream(string roomId, string userId, RtcMediaStreamType mediaType)
		{
		}

		public static long ppf_Rtc_SendRoomBinaryMessage(string roomId, IntPtr message, int length)
		{
			return 0L;
		}

		public static long ppf_Rtc_SendRoomMessage(string roomId, string message)
		{
			return 0L;
		}

		public static int ppf_Rtc_SendStreamSyncInfo(IntPtr data, int length, IntPtr config)
		{
			return 0;
		}

		public static long ppf_Rtc_SendUserBinaryMessage(string roomId, string userId, IntPtr message, int length)
		{
			return 0L;
		}

		public static long ppf_Rtc_SendUserMessage(string roomId, string userId, string message)
		{
			return 0L;
		}

		public static int ppf_Rtc_SetAudioSourceType(RtcAudioSourceType type)
		{
			return 0;
		}

		public static void ppf_Rtc_SetScreenAudioSourceType(RtcAudioSourceType sourceType)
		{
		}

		public static int ppf_Rtc_PushExternalAudioFrame(IntPtr audioFrame)
		{
			return 0;
		}

		public static void ppf_StartAsrOptions_Destroy(IntPtr obj)
		{
		}

		public static IntPtr ppf_StartAsrOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_StartAsrOptions_SetAutoStop(IntPtr obj, bool value)
		{
		}

		public static void ppf_StartAsrOptions_SetVadMaxDurationInSeconds(IntPtr obj, int value)
		{
		}

		public static void ppf_StartAsrOptions_SetShowPunctual(IntPtr obj, bool value)
		{
		}

		public static AsrEngineInitResult ppf_Speech_InitAsrEngine()
		{
			return default(AsrEngineInitResult);
		}

		public static int ppf_Speech_StartAsr(IntPtr option)
		{
			return 0;
		}

		public static void ppf_Speech_StopAsr()
		{
		}

		public static ulong ppf_Game_InitializeWithToken(string accessToken)
		{
			return 0uL;
		}

		public static ulong ppf_Game_InitializeWithTokenAccountTypeOne(string accessToken)
		{
			return 0uL;
		}

		public static ulong ppf_Game_InitializeAuto()
		{
			return 0uL;
		}

		public static bool ppf_Game_UnInitialize()
		{
			return false;
		}

		public static IntPtr ppf_InviteOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_InviteOptions_Destroy(IntPtr handle)
		{
		}

		public static void ppf_InviteOptions_AddSuggestedUser(IntPtr handle, string value)
		{
		}

		public static void ppf_InviteOptions_ClearSuggestedUsers(IntPtr handle)
		{
		}

		public static IntPtr ppf_KeyValuePair_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_KeyValuePair_Destroy(IntPtr obj)
		{
		}

		public static string ppf_KeyValuePair_GetKey(IntPtr obj)
		{
			return null;
		}

		public static void ppf_KeyValuePair_SetKey(IntPtr obj, string key)
		{
		}

		public static KVPairType ppf_KeyValuePair_GetValueType(IntPtr obj)
		{
			return default(KVPairType);
		}

		public static int ppf_KeyValuePair_GetIntValue(IntPtr obj)
		{
			return 0;
		}

		public static void ppf_KeyValuePair_SetIntValue(IntPtr obj, int value)
		{
		}

		public static double ppf_KeyValuePair_GetDoubleValue(IntPtr obj)
		{
			return 0.0;
		}

		public static void ppf_KeyValuePair_SetDoubleValue(IntPtr obj, double value)
		{
		}

		public static string ppf_KeyValuePair_GetStringValue(IntPtr obj)
		{
			return null;
		}

		public static void ppf_KeyValuePair_SetStringValue(IntPtr obj, string value)
		{
		}

		public static IntPtr ppf_KeyValuePairArray_Create(UIntPtr size)
		{
			return (IntPtr)0;
		}

		public static void ppf_KeyValuePairArray_Destroy(IntPtr obj)
		{
		}

		public static IntPtr ppf_KeyValuePairArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static bool ppf_LaunchFriendRequestFlowResult_GetDidCancel(IntPtr obj)
		{
			return false;
		}

		public static bool ppf_LaunchFriendRequestFlowResult_GetDidSendRequest(IntPtr obj)
		{
			return false;
		}

		public static IntPtr ppf_LeaderboardArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_LeaderboardArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_LeaderboardArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static ulong ppf_LeaderboardArray_GetTotalCount(IntPtr obj)
		{
			return 0uL;
		}

		public static bool ppf_LeaderboardArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static ulong ppf_SupplementaryMetric_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static long ppf_SupplementaryMetric_GetMetric(IntPtr obj)
		{
			return 0L;
		}

		public static IntPtr ppf_LeaderboardEntry_GetSupplementaryMetric(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static string ppf_LeaderboardEntry_GetDisplayScore(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_LeaderboardEntry_GetExtraData(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static uint ppf_LeaderboardEntry_GetExtraDataLength(IntPtr obj)
		{
			return 0u;
		}

		public static ulong ppf_LeaderboardEntry_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static int ppf_LeaderboardEntry_GetRank(IntPtr obj)
		{
			return 0;
		}

		public static long ppf_LeaderboardEntry_GetScore(IntPtr obj)
		{
			return 0L;
		}

		public static ulong ppf_LeaderboardEntry_GetTimestamp(IntPtr obj)
		{
			return 0uL;
		}

		public static IntPtr ppf_LeaderboardEntry_GetUser(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_LeaderboardEntryArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_LeaderboardEntryArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		public static string ppf_LeaderboardEntryArray_GetPreviousUrl(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_LeaderboardEntryArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static ulong ppf_LeaderboardEntryArray_GetTotalCount(IntPtr obj)
		{
			return 0uL;
		}

		public static bool ppf_LeaderboardEntryArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static bool ppf_LeaderboardEntryArray_HasPreviousPage(IntPtr obj)
		{
			return false;
		}

		public static string ppfLeaderboardFilterType_ToString(LeaderboardFilterType value)
		{
			return null;
		}

		public static LeaderboardFilterType ppfLeaderboardFilterType_FromString(string str)
		{
			return default(LeaderboardFilterType);
		}

		public static string ppfLeaderboardStartAt_ToString(LeaderboardStartAt value)
		{
			return null;
		}

		public static LeaderboardStartAt ppfLeaderboardStartAt_FromString(string str)
		{
			return default(LeaderboardStartAt);
		}

		public static bool ppf_LeaderboardUpdateStatus_GetDidUpdate(IntPtr obj)
		{
			return false;
		}

		public static ulong ppf_LeaderboardUpdateStatus_GetUpdatedChallengeId(IntPtr obj, uint index)
		{
			return 0uL;
		}

		public static uint ppf_LeaderboardUpdateStatus_GetUpdatedChallengeIdsSize(IntPtr obj)
		{
			return 0u;
		}

		public static bool ppf_MatchmakingAdminSnapshotCandidate_GetCanMatch(IntPtr obj)
		{
			return false;
		}

		public static double ppf_MatchmakingAdminSnapshotCandidate_GetMyTotalScore(IntPtr obj)
		{
			return 0.0;
		}

		public static double ppf_MatchmakingAdminSnapshotCandidate_GetTheirCurrentThreshold(IntPtr obj)
		{
			return 0.0;
		}

		public static IntPtr ppf_MatchmakingAdminSnapshotCandidateArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_MatchmakingAdminSnapshotCandidateArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static UIntPtr ppf_MatchmakingAdminSnapshotCandidateArray_GetTotalCount(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static IntPtr ppf_MatchmakingAdminSnapshot_GetCandidates(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static double ppf_MatchmakingAdminSnapshot_GetMyCurrentThreshold(IntPtr obj)
		{
			return 0.0;
		}

		public static IntPtr ppf_MatchmakingEnqueueResult_GetAdminSnapshot(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static uint ppf_MatchmakingEnqueueResult_GetAverageWait(IntPtr obj)
		{
			return 0u;
		}

		public static uint ppf_MatchmakingEnqueueResult_GetMatchesInLastHourCount(IntPtr obj)
		{
			return 0u;
		}

		public static uint ppf_MatchmakingEnqueueResult_GetMaxExpectedWait(IntPtr obj)
		{
			return 0u;
		}

		public static uint ppf_MatchmakingEnqueueResult_GetRecentMatchPercentage(IntPtr obj)
		{
			return 0u;
		}

		public static string ppf_MatchmakingEnqueueResult_GetPool(IntPtr obj)
		{
			return null;
		}

		public static string ppfRoomJoinability_ToString(RoomJoinability value)
		{
			return null;
		}

		public static RoomJoinability ppfRoomJoinability_FromString(string str)
		{
			return default(RoomJoinability);
		}

		public static string ppfRoomJoinPolicy_ToString(RoomJoinPolicy value)
		{
			return null;
		}

		public static RoomJoinPolicy ppfRoomJoinPolicy_FromString(string str)
		{
			return default(RoomJoinPolicy);
		}

		public static string ppfRoomType_ToString(RoomType value)
		{
			return null;
		}

		public static RoomType ppfRoomType_FromString(string str)
		{
			return default(RoomType);
		}

		public static IntPtr ppf_Room_GetDataStore(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Room_GetOwner(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static string ppf_Room_GetName(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_Room_GetUsers(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static string ppf_Room_GetDescription(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_Room_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static bool ppf_Room_GetIsMembershipLocked(IntPtr obj)
		{
			return false;
		}

		public static RoomJoinPolicy ppf_Room_GetJoinPolicy(IntPtr obj)
		{
			return default(RoomJoinPolicy);
		}

		public static RoomJoinability ppf_Room_GetJoinability(IntPtr obj)
		{
			return default(RoomJoinability);
		}

		public static uint ppf_Room_GetMaxUsers(IntPtr obj)
		{
			return 0u;
		}

		public static RoomType ppf_Room_GetType(IntPtr obj)
		{
			return default(RoomType);
		}

		public static uint ppf_Room_GetPlayerNumber(IntPtr obj)
		{
			return 0u;
		}

		public static uint ppf_MatchmakingRoom_GetPingTime(IntPtr obj)
		{
			return 0u;
		}

		public static IntPtr ppf_MatchmakingRoom_GetRoom(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static bool ppf_MatchmakingRoom_HasPingTime(IntPtr obj)
		{
			return false;
		}

		public static IntPtr ppf_MatchmakingRoomArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_MatchmakingRoomArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static int ppf_MatchmakingRoomArray_GetTotalCount(IntPtr obj)
		{
			return 0;
		}

		public static IntPtr ppf_MatchmakingBrowseResult_GetEnqueueResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_MatchmakingBrowseResult_GetRooms(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_MatchmakingEnqueueResultAndRoom_GetMatchmakingEnqueueResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_MatchmakingEnqueueResultAndRoom_GetRoom(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_MatchmakingOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_MatchmakingOptions_Destroy(IntPtr handle)
		{
		}

		public static void ppf_MatchmakingOptions_SetCreateRoomDataStoreString(IntPtr handle, string key, string value)
		{
		}

		public static void ppf_MatchmakingOptions_ClearCreateRoomDataStore(IntPtr handle)
		{
		}

		public static void ppf_MatchmakingOptions_SetCreateRoomJoinPolicy(IntPtr handle, RoomJoinPolicy value)
		{
		}

		public static void ppf_MatchmakingOptions_SetCreateRoomMaxUsers(IntPtr handle, uint value)
		{
		}

		public static void ppf_MatchmakingOptions_ClearEnqueueAdditionalUsers(IntPtr handle)
		{
		}

		public static void ppf_MatchmakingOptions_SetEnqueueDataSettingsInt(IntPtr handle, string key, int value)
		{
		}

		public static void ppf_MatchmakingOptions_SetEnqueueDataSettingsDouble(IntPtr handle, string key, double value)
		{
		}

		public static void ppf_MatchmakingOptions_SetEnqueueDataSettingsString(IntPtr handle, string key, string value)
		{
		}

		public static void ppf_MatchmakingOptions_ClearEnqueueDataSettings(IntPtr handle)
		{
		}

		public static void ppf_MatchmakingOptions_SetEnqueueIsDebug(IntPtr handle, bool value)
		{
		}

		public static void ppf_MatchmakingOptions_SetEnqueueQueryKey(IntPtr handle, string value)
		{
		}

		public static uint ppf_MatchmakingStats_GetDrawCount(IntPtr obj)
		{
			return 0u;
		}

		public static uint ppf_MatchmakingStats_GetLossCount(IntPtr obj)
		{
			return 0u;
		}

		public static uint ppf_MatchmakingStats_GetSkillLevel(IntPtr obj)
		{
			return 0u;
		}

		public static double ppf_MatchmakingStats_GetSkillMean(IntPtr obj)
		{
			return 0.0;
		}

		public static double ppf_MatchmakingStats_GetSkillStandardDeviation(IntPtr obj)
		{
			return 0.0;
		}

		public static uint ppf_MatchmakingStats_GetWinCount(IntPtr obj)
		{
			return 0u;
		}

		public static IntPtr ppf_UserAndRoom_GetUser(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_UserAndRoom_GetRoom(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_UserAndRoomArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_UserAndRoomArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_UserAndRoomArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static string ppf_UserAndRoomArray_GetNextPageParam(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcJoinRoomResult_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcJoinRoomResult_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static int ppf_RtcJoinRoomResult_GetErrorCode(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_RtcJoinRoomResult_GetElapsed(IntPtr obj)
		{
			return 0;
		}

		public static RtcJoinRoomType ppf_RtcJoinRoomResult_GetJoinType(IntPtr obj)
		{
			return default(RtcJoinRoomType);
		}

		public static string ppf_RtcLeaveRoomResult_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static int ppf_RtcRoomStats_GetTotalDuration(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_RtcRoomStats_GetUserCount(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_RtcRoomStats_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcUserJoinInfo_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcUserJoinInfo_GetUserExtra(IntPtr obj)
		{
			return null;
		}

		public static int ppf_RtcUserJoinInfo_GetElapsed(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_RtcUserJoinInfo_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcUserLeaveInfo_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static RtcUserLeaveReasonType ppf_RtcUserLeaveInfo_GetOfflineReason(IntPtr obj)
		{
			return default(RtcUserLeaveReasonType);
		}

		public static string ppf_RtcUserLeaveInfo_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static int ppf_RtcRoomWarn_GetCode(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_RtcRoomWarn_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static int ppf_RtcRoomError_GetCode(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_RtcRoomError_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcMuteInfo_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static RtcMuteState ppf_RtcMuteInfo_GetMuteState(IntPtr obj)
		{
			return default(RtcMuteState);
		}

		public static string ppf_RtcMediaDeviceChangeInfo_GetDeviceId(IntPtr obj)
		{
			return null;
		}

		public static RtcMediaDeviceType ppf_RtcMediaDeviceChangeInfo_GetDeviceType(IntPtr obj)
		{
			return default(RtcMediaDeviceType);
		}

		public static RtcMediaDeviceState ppf_RtcMediaDeviceChangeInfo_GetDeviceState(IntPtr obj)
		{
			return default(RtcMediaDeviceState);
		}

		public static RtcMediaDeviceError ppf_RtcMediaDeviceChangeInfo_GetDeviceError(IntPtr obj)
		{
			return default(RtcMediaDeviceError);
		}

		public static int ppf_RtcAudioPropertyInfo_GetVolume(IntPtr obj)
		{
			return 0;
		}

		public static RtcStreamIndex ppf_RtcLocalAudioPropertiesInfo_GetStreamIndex(IntPtr obj)
		{
			return default(RtcStreamIndex);
		}

		public static IntPtr ppf_RtcLocalAudioPropertiesInfo_GetAudioPropertyInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_RtcLocalAudioPropertiesReport_GetAudioPropertiesInfos(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_RtcLocalAudioPropertiesReport_GetAudioPropertiesInfosSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static string ppf_RtcRemoteStreamKey_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcRemoteStreamKey_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static RtcStreamIndex ppf_RtcRemoteStreamKey_GetStreamIndex(IntPtr obj)
		{
			return default(RtcStreamIndex);
		}

		public static IntPtr ppf_RtcRemoteAudioPropertiesInfo_GetStreamKey(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_RtcRemoteAudioPropertiesInfo_GetAudioPropertiesInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_RtcRemoteAudioPropertiesReport_GetAudioPropertiesInfos(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_RtcRemoteAudioPropertiesReport_GetAudioPropertiesInfosSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static int ppf_RtcRemoteAudioPropertiesReport_GetTotalRemoteVolume(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_RtcRoomMessageReceived_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcRoomMessageReceived_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcRoomMessageReceived_GetMessage(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcBinaryMessageReceived_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_RtcBinaryMessageReceived_GetData(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static int ppf_RtcBinaryMessageReceived_GetLength(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_RtcBinaryMessageReceived_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_RtcStreamSyncInfo_GetStreamKey(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static RtcSyncInfoStreamType ppf_RtcStreamSyncInfo_GetStreamType(IntPtr obj)
		{
			return default(RtcSyncInfoStreamType);
		}

		public static IntPtr ppf_RtcStreamSyncInfo_GetData(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static int ppf_RtcStreamSyncInfo_GetLength(IntPtr obj)
		{
			return 0;
		}

		public static RtcStreamIndex ppf_RtcFirstLocalVideoFrameCapturedInfo_GetStreamIndex(IntPtr obj)
		{
			return default(RtcStreamIndex);
		}

		public static string ppf_RtcFirstLocalVideoFrameCapturedInfo_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static RtcStreamIndex ppf_RtcLocalVideoSizeChangeInfo_GetStreamIndex(IntPtr obj)
		{
			return default(RtcStreamIndex);
		}

		public static string ppf_RtcLocalVideoSizeChangeInfo_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcUserPublishInfo_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static RtcMediaStreamType ppf_RtcUserPublishInfo_GetMediaStreamType(IntPtr obj)
		{
			return default(RtcMediaStreamType);
		}

		public static string ppf_RtcUserPublishInfo_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcUserUnPublishInfo_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static RtcMediaStreamType ppf_RtcUserUnPublishInfo_GetMediaStreamType(IntPtr obj)
		{
			return default(RtcMediaStreamType);
		}

		public static RtcStreamRemoveReason ppf_RtcUserUnPublishInfo_GetReason(IntPtr obj)
		{
			return default(RtcStreamRemoveReason);
		}

		public static string ppf_RtcUserUnPublishInfo_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_RoomArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_RoomArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static int ppf_RoomArray_GetTotalCount(IntPtr obj)
		{
			return 0;
		}

		public static bool ppf_RoomArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static int ppf_RoomArray_GetPageSize(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_RoomArray_GetPageIndex(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_RtcUserMessageReceived_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcUserMessageReceived_GetUserId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RtcUserMessageReceived_GetMessage(IntPtr obj)
		{
			return null;
		}

		public static long ppf_RtcMessageSendResult_GetMessageId(IntPtr obj)
		{
			return 0L;
		}

		public static int ppf_RtcMessageSendResult_GetError(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_RtcMessageSendResult_GetRoomId(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_CloudStorage_StartNewBackup()
		{
			return 0uL;
		}

		public static string ppfPlatformGameInitializeResult_ToString(GameInitializeResult value)
		{
			return null;
		}

		public static GameInitializeResult ppfPlatformGameInitializeResult_FromString(string str)
		{
			return default(GameInitializeResult);
		}

		public static GameInitializeResult ppf_PlatformGameInitialize_GetResult(IntPtr obj)
		{
			return default(GameInitializeResult);
		}

		public static IntPtr ppf_SendInvitesResult_GetInvites(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static string ppf_PresenceJoinIntent_GetDeeplinkMessage(IntPtr obj)
		{
			return null;
		}

		public static string ppf_PresenceJoinIntent_GetDestinationApiName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_PresenceJoinIntent_GetLobbySessionId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_PresenceJoinIntent_GetMatchSessionId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_PresenceJoinIntent_GetExtra(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_RoomInviteNotification_GetID(IntPtr obj)
		{
			return 0uL;
		}

		public static ulong ppf_RoomInviteNotification_GetRoomID(IntPtr obj)
		{
			return 0uL;
		}

		public static string ppf_RoomInviteNotification_GetSenderID(IntPtr obj)
		{
			return null;
		}

		public static ulong ppf_RoomInviteNotification_GetSentTime(IntPtr obj)
		{
			return 0uL;
		}

		public static IntPtr ppf_RoomInviteNotificationArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static string ppf_RoomInviteNotificationArray_GetNextUrl(IntPtr obj)
		{
			return null;
		}

		public static UIntPtr ppf_RoomInviteNotificationArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static int ppf_RoomInviteNotificationArray_GetTotalCount(IntPtr obj)
		{
			return 0;
		}

		public static bool ppf_RoomInviteNotificationArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static Gender ppf_SportUserInfo_GetGender(IntPtr obj)
		{
			return default(Gender);
		}

		public static long ppf_SportUserInfo_GetBirthday(IntPtr obj)
		{
			return 0L;
		}

		public static int ppf_SportUserInfo_GetStature(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_SportUserInfo_GetWeight(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_SportUserInfo_GetSportLevel(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_SportUserInfo_GetDailyDurationInMinutes(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_SportUserInfo_GetDaysPerWeek(IntPtr obj)
		{
			return 0;
		}

		public static SportTarget ppf_SportUserInfo_GetSportTarget(IntPtr obj)
		{
			return default(SportTarget);
		}

		public static long ppf_SportDailySummary_GetId(IntPtr obj)
		{
			return 0L;
		}

		public static long ppf_SportDailySummary_GetDate(IntPtr obj)
		{
			return 0L;
		}

		public static int ppf_SportDailySummary_GetDurationInSeconds(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_SportDailySummary_GetPlanDurationInMinutes(IntPtr obj)
		{
			return 0;
		}

		public static double ppf_SportDailySummary_GetCalorie(IntPtr obj)
		{
			return 0.0;
		}

		public static double ppf_SportDailySummary_GetPlanCalorie(IntPtr obj)
		{
			return 0.0;
		}

		public static IntPtr ppf_SportDailySummaryArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_SportDailySummaryArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static long ppf_SportSummary_GetDurationInSeconds(IntPtr obj)
		{
			return 0L;
		}

		public static double ppf_SportSummary_GetCalorie(IntPtr obj)
		{
			return 0.0;
		}

		public static long ppf_SportSummary_GetStartTime(IntPtr obj)
		{
			return 0L;
		}

		public static long ppf_SportSummary_GetEndTime(IntPtr obj)
		{
			return 0L;
		}

		public static long ppf_Purchase_GetExpirationTime(IntPtr obj)
		{
			return 0L;
		}

		public static long ppf_Purchase_GetGrantTime(IntPtr obj)
		{
			return 0L;
		}

		public static string ppf_Purchase_GetID(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Purchase_GetSKU(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Purchase_GetIcon(IntPtr obj)
		{
			return null;
		}

		public static AddonsType ppf_Purchase_GetAddonsType(IntPtr obj)
		{
			return default(AddonsType);
		}

		public static string ppf_Purchase_GetOuterId(IntPtr obj)
		{
			return null;
		}

		public static PeriodType ppf_Purchase_GetCurrentPeriodType(IntPtr obj)
		{
			return default(PeriodType);
		}

		public static PeriodType ppf_Purchase_GetNextPeriodType(IntPtr obj)
		{
			return default(PeriodType);
		}

		public static long ppf_Purchase_GetNextPayTime(IntPtr obj)
		{
			return 0L;
		}

		public static DiscountType ppf_Purchase_GetDiscountType(IntPtr obj)
		{
			return default(DiscountType);
		}

		public static string ppf_Purchase_GetOrderComment(IntPtr obj)
		{
			return null;
		}

		public static IntPtr ppf_PurchaseArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_PurchaseArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_PurchaseArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static string ppf_PurchaseArray_GetNextPageParam(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetDescription(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetDetailDescription(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetPrice(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetCurrency(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetName(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetSKU(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetIcon(IntPtr obj)
		{
			return null;
		}

		public static AddonsType ppf_Product_GetAddonsType(IntPtr obj)
		{
			return default(AddonsType);
		}

		public static PeriodType ppf_Product_GetPeriodType(IntPtr obj)
		{
			return default(PeriodType);
		}

		public static PeriodType ppf_Product_GetTrialPeriodUnit(IntPtr obj)
		{
			return default(PeriodType);
		}

		public static int ppf_Product_GetTrialPeriodValue(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_Product_GetOuterId(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetOriginalPrice(IntPtr obj)
		{
			return null;
		}

		public static string ppf_Product_GetGroupId(IntPtr obj)
		{
			return null;
		}

		public static int ppf_Product_GetLevel(IntPtr obj)
		{
			return 0;
		}

		public static bool ppf_Product_IsContinuous(IntPtr obj)
		{
			return false;
		}

		public static IntPtr ppf_ProductArray_GetElement(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_ProductArray_GetSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static bool ppf_ProductArray_HasNextPage(IntPtr obj)
		{
			return false;
		}

		public static string ppf_ProductArray_GetNextPageParam(IntPtr obj)
		{
			return null;
		}

		public static string ppf_PermissionResult_GetAuthorizedPermissions(IntPtr obj, UIntPtr index)
		{
			return null;
		}

		public static UIntPtr ppf_PermissionResult_GetAuthorizedPermissionsSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static string ppf_PermissionResult_GetAccessToken(IntPtr obj)
		{
			return null;
		}

		public static string ppf_PermissionResult_GetUserID(IntPtr obj)
		{
			return null;
		}

		public static string ppf_SubscriptionStatus_GetSKU(IntPtr obj)
		{
			return null;
		}

		public static string ppf_SubscriptionStatus_GetOuterId(IntPtr obj)
		{
			return null;
		}

		public static long ppf_SubscriptionStatus_GetStartTime(IntPtr obj)
		{
			return 0L;
		}

		public static long ppf_SubscriptionStatus_GetEndTime(IntPtr obj)
		{
			return 0L;
		}

		public static PeriodType ppf_SubscriptionStatus_GetPeriodType(IntPtr obj)
		{
			return default(PeriodType);
		}

		public static EntitlementStatus ppf_SubscriptionStatus_GetEntitlementStatus(IntPtr obj)
		{
			return default(EntitlementStatus);
		}

		public static CancelReason ppf_SubscriptionStatus_GetCancelReason(IntPtr obj)
		{
			return default(CancelReason);
		}

		public static bool ppf_SubscriptionStatus_GetIsFreeTrial(IntPtr obj)
		{
			return false;
		}

		public static int ppf_SubscriptionStatus_GetNextPeriod(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_UserRelationResult_GetRelationsKey(IntPtr obj, int index)
		{
			return null;
		}

		public static UserRelationType ppf_UserRelationResult_GetRelationsValue(IntPtr obj, int index)
		{
			return default(UserRelationType);
		}

		public static int ppf_UserRelationResult_GetRelationsSize(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_SpeechError_GetMessage(IntPtr obj)
		{
			return null;
		}

		public static string ppf_SpeechError_GetSessionId(IntPtr obj)
		{
			return null;
		}

		public static int ppf_SpeechError_GetCode(IntPtr obj)
		{
			return 0;
		}

		public static string ppf_OrgScopedID_GetID(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RecordInfo_GetVideoPath(IntPtr obj)
		{
			return null;
		}

		public static string ppf_RecordInfo_GetJobId(IntPtr obj)
		{
			return null;
		}

		public static int ppf_RecordInfo_GetDurationInMilliSeconds(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_RecordInfo_GetWidth(IntPtr obj)
		{
			return 0;
		}

		public static int ppf_RecordInfo_GetHeight(IntPtr obj)
		{
			return 0;
		}

		public static IntPtr ppf_SessionMedia_GetImages(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_SessionMedia_GetImagesSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static IntPtr ppf_SessionMedia_GetVideos(IntPtr obj, UIntPtr index)
		{
			return (IntPtr)0;
		}

		public static UIntPtr ppf_SessionMedia_GetVideosSize(IntPtr obj)
		{
			return (UIntPtr)0u;
		}

		public static IntPtr ppf_Message_GetUser(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static string ppf_Message_GetString(IntPtr obj)
		{
			return null;
		}

		public static int ppf_Message_GetInt32(IntPtr obj)
		{
			return 0;
		}

		public static MessageType ppf_Message_GetType(IntPtr obj)
		{
			return default(MessageType);
		}

		public static IntPtr ppf_Message_GetError(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static bool ppf_Message_IsError(IntPtr obj)
		{
			return false;
		}

		public static ulong ppf_Message_GetRequestID(IntPtr obj)
		{
			return 0uL;
		}

		public static IntPtr ppf_Message_GetUserArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetLaunchFriendRequestFlowResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetUserAndRoomArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetPermissionResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetApplicationVersion(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetUserRelationResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetSubscriptionStatus(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetEntitlementCheckResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcJoinRoomResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcLeaveRoomResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcRoomStats(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcUserJoinInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcUserLeaveInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcRoomWarn(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcRoomError(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcMuteInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static RtcAudioPlaybackDevice ppf_Message_GetRtcAudioPlaybackDevice(IntPtr obj)
		{
			return default(RtcAudioPlaybackDevice);
		}

		public static IntPtr ppf_Message_GetRtcMediaDeviceChangeInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcLocalAudioPropertiesReport(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcRemoteAudioPropertiesReport(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcRoomMessageReceived(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcUserMessageReceived(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcBinaryMessageReceived(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcStreamSyncInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcFirstLocalVideoFrameCapturedInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcLocalVideoSizeChangeInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcMessageSendResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcUserPublishInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRtcUserUnPublishInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetMatchmakingAdminSnapshot(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetMatchmakingBrowseResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetMatchmakingBrowseCustomPageResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetMatchmakingEnqueueResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetMatchmakingEnqueueResultAndRoom(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetMatchmakingStats(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRoom(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRoomArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetPlatformGameInitialize(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static GameConnectionEvent ppf_Message_GetGameConnectionEvent(IntPtr obj)
		{
			return default(GameConnectionEvent);
		}

		public static GameRequestFailedReason ppf_Message_GetGameRequestFailedReason(IntPtr obj)
		{
			return default(GameRequestFailedReason);
		}

		public static IntPtr ppf_Message_GetApplicationInviteArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetSendInvitesResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetDestinationArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetPresenceJoinIntent(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRoomInviteNotificationArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetLeaderboardArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetLeaderboardUpdateStatus(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetLeaderboardEntryArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAchievementDefinitionArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAchievementProgressArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAchievementUpdate(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetChallenge(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetChallengeArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetChallengeEntryArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetPurchaseArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetProductArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetPurchase(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetSportUserInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetSportDailySummaryArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetSportSummary(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAssetDetails(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAssetDetailsArray(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAssetFileDeleteResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAssetFileDownloadCancelResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAssetFileDownloadResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAssetFileDownloadUpdate(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAssetStatus(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAssetFileDeleteForSafety(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetAsrResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetSpeechError(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetDetectSensitiveResult(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetOrgScopedID(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetCaptureInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetRecordInfo(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static IntPtr ppf_Message_GetSessionMedia(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static PlatformInitializeResult ppf_PcInitWrapper(string appId, string configPath, string logPath)
		{
			return default(PlatformInitializeResult);
		}

		public static ulong ppf_PcInitAsynchronousWrapper(string appId, string configJson, string logPath)
		{
			return 0uL;
		}

		public static int ppf_PcUnInitialize()
		{
			return 0;
		}

		public static void ppf_RegisterFunctions()
		{
		}

		public static int ppf_GetLoaderVersion()
		{
			return 0;
		}

		public static IntPtr ppf_PresenceOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_PresenceOptions_Destroy(IntPtr handle)
		{
		}

		public static void ppf_PresenceOptions_SetDestinationApiName(IntPtr handle, string value)
		{
		}

		public static void ppf_PresenceOptions_SetIsJoinable(IntPtr handle, bool value)
		{
		}

		public static void ppf_PresenceOptions_SetLobbySessionId(IntPtr handle, string value)
		{
		}

		public static void ppf_PresenceOptions_SetMatchSessionId(IntPtr handle, string value)
		{
		}

		public static void ppf_PresenceOptions_SetExtra(IntPtr handle, string value)
		{
		}

		public static ulong ppf_Achievements_AddCount(string name, long count, IntPtr extra_data, uint extra_data_length)
		{
			return 0uL;
		}

		public static ulong ppf_Achievements_AddFields(string name, string fields, IntPtr extra_data, uint extra_data_length)
		{
			return 0uL;
		}

		public static ulong ppf_Achievements_GetAllDefinitions(int pageIdx, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Achievements_GetAllProgress(int pageIdx, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Achievements_GetDefinitionsByName(IntPtr[] names, int count)
		{
			return 0uL;
		}

		public static ulong ppf_Achievements_GetProgressByName(IntPtr[] names, int count)
		{
			return 0uL;
		}

		public static ulong ppf_Achievements_Unlock(string name, IntPtr extra_data, uint extra_data_length)
		{
			return 0uL;
		}

		public static ulong ppf_Application_LaunchOtherApp(string packageName, IntPtr deeplink_options)
		{
			return 0uL;
		}

		public static ulong ppf_Application_LaunchOtherAppByAppID(string appID, IntPtr deeplink_options)
		{
			return 0uL;
		}

		public static ulong ppf_Application_LaunchOtherAppByPresence(string appID, string packageName, IntPtr options)
		{
			return 0uL;
		}

		public static ulong ppf_Application_LaunchOtherAppByMessage(IntPtr options)
		{
			return 0uL;
		}

		public static ulong ppf_Application_GetVersion()
		{
			return 0uL;
		}

		public static ulong ppf_Application_LaunchStore()
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_DeleteById(ulong assetFileID)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_DeleteByName(string assetFileName)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_DownloadById(ulong assetFileID)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_DownloadByName(string assetFileName)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_DownloadCancelById(ulong assetFileID)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_DownloadCancelByName(string assetFileName)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_GetList()
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_GetNextAssetDetailsArrayPage(string @params)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_StatusById(ulong assetFileID)
		{
			return 0uL;
		}

		public static ulong ppf_AssetFile_StatusByName(string assetFileName)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_Invites(ulong challengeID, IntPtr[] userIDs, uint userIDLength)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_Get(ulong challengeID)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_GetEntries(ulong challengeID, LeaderboardFilterType filter, LeaderboardStartAt startAt, int pageIdx, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_GetEntriesAfterRank(ulong challengeID, ulong afterRank, int pageIdx, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_GetEntriesByIds(ulong challengeID, LeaderboardStartAt startAt, IntPtr[] userIDs, uint userIDLength, int pageIdx, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_GetList(IntPtr challengeOptions, int pageIdx, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_Join(ulong challengeID)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_Leave(ulong challengeID)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_LaunchInvitableUserFlow(ulong challengeID)
		{
			return 0uL;
		}

		public static ulong ppf_Compliance_DetectSensitive(DetectSensitiveScene scene, string content)
		{
			return 0uL;
		}

		public static ulong ppf_Highlight_CaptureScreen()
		{
			return 0uL;
		}

		public static ulong ppf_Highlight_ListMedia(string sessionId)
		{
			return 0uL;
		}

		public static ulong ppf_Highlight_SaveMedia(string jobId, string sessionId)
		{
			return 0uL;
		}

		public static ulong ppf_Highlight_ShareMedia(string jobId, string sessionId)
		{
			return 0uL;
		}

		public static ulong ppf_Highlight_StartRecord()
		{
			return 0uL;
		}

		public static ulong ppf_Highlight_StartSession()
		{
			return 0uL;
		}

		public static ulong ppf_Highlight_StopRecord()
		{
			return 0uL;
		}

		public static ulong ppf_IAP_ConsumePurchase(string sku)
		{
			return 0uL;
		}

		public static ulong ppf_IAP_GetNextProductArrayPage(string nextPageParam)
		{
			return 0uL;
		}

		public static ulong ppf_IAP_GetNextPurchaseArrayPage(string nextPageParam)
		{
			return 0uL;
		}

		public static ulong ppf_IAP_GetProductsBySKU(IntPtr[] skus, int size)
		{
			return 0uL;
		}

		public static ulong ppf_IAP_GetViewerPurchases()
		{
			return 0uL;
		}

		public static ulong ppf_IAP_LaunchCheckoutFlow(string sku, string price, string currency)
		{
			return 0uL;
		}

		public static ulong ppf_IAP_LaunchCheckoutFlowV2(string sku, string price, string currency, string outerId)
		{
			return 0uL;
		}

		public static ulong ppf_IAP_LaunchCheckoutFlowV3(string sku, string price, string currency, string outerId, string orderComment)
		{
			return 0uL;
		}

		public static ulong ppf_IAP_GetSubscriptionStatus(string sku)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_Get(string leaderboardName)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_GetEntries(string leaderboardName, int pageSize, int pageIdx, LeaderboardFilterType filter, LeaderboardStartAt startAt)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_GetEntriesAfterRank(string leaderboardName, int pageSize, int pageIdx, ulong afterRank)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_GetEntriesByIds(string leaderboardName, int pageSize, int pageIdx, LeaderboardStartAt startAt, IntPtr[] userIDs, uint userIDLength)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_GetNextEntries(IntPtr handle)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_GetNextLeaderboardArrayPage(IntPtr handle)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_GetPreviousEntries(IntPtr handle)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_WriteEntry(string leaderboardName, long score, IntPtr extraData, uint extraDataLength, bool forceUpdate)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_WriteEntryWithSupplementaryMetric(string leaderboardName, long score, long supplementaryMetric, IntPtr extraData, uint extraDataLength, bool forceUpdate)
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_Browse2(string pool, IntPtr matchmakingOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_Browse2CustomPage(string pool, IntPtr matchmakingOptions, int pageIndex, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_Cancel2()
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_CreateAndEnqueueRoom2(string pool, IntPtr matchmakingOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_Enqueue2(string pool, IntPtr matchmakingOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_GetAdminSnapshot()
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_GetStats(string pool, uint maxLevel, MatchmakingStatApproach approach)
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_ReportResultInsecure(ulong roomID, IntPtr data, uint numItems)
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_StartMatch(ulong roomID)
		{
			return 0uL;
		}

		public static ulong ppf_Matchmaking_CrashTest()
		{
			return 0uL;
		}

		public static ulong ppf_Notification_GetNextRoomInviteNotificationArrayPage(IntPtr handle)
		{
			return 0uL;
		}

		public static ulong ppf_Notification_GetRoomInvites(int pageIdx, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Notification_MarkAsRead(ulong notificationID)
		{
			return 0uL;
		}

		public static void ppf_ShareMediaOptions_Destroy(IntPtr obj)
		{
		}

		public static IntPtr ppf_ShareMediaOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_ShareMediaOptions_SetShareMediaType(IntPtr obj, ShareMediaType value)
		{
		}

		public static void ppf_ShareMediaOptions_SetVideoPath(IntPtr obj, string value)
		{
		}

		public static void ppf_ShareMediaOptions_SetVideoThumbPath(IntPtr obj, string value)
		{
		}

		public static void ppf_ShareMediaOptions_AddImagePath(IntPtr obj, string value)
		{
		}

		public static void ppf_ShareMediaOptions_ClearImagePaths(IntPtr obj)
		{
		}

		public static void ppf_ShareMediaOptions_SetShareAppType(IntPtr obj, ShareAppType value)
		{
		}

		public static ulong ppf_Presence_Clear()
		{
			return 0uL;
		}

		public static ulong ppf_Presence_GetInvitableUsers(IntPtr options)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_GetNextApplicationInviteArrayPage(string @params)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_GetSentInvites()
		{
			return 0uL;
		}

		public static ulong ppf_Presence_SendInvites(IntPtr[] userIDs, uint userIDLength)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_SendCustomInvites(string msg, IntPtr[] userIDs, uint userIDLength)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_Set(IntPtr presenceOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_SetDestination(string api_name)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_SetIsJoinable(bool is_joinable)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_SetLobbySession(string id)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_SetMatchSession(string id)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_SetExtra(string extra)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_GetDestinations()
		{
			return 0uL;
		}

		public static ulong ppf_Presence_GetNextDestinationArrayPage(string @params)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_ShareMedia(IntPtr shareMediaOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_LaunchInvitePanel()
		{
			return 0uL;
		}

		public static string ppfRoomMembershipLockStatus_ToString(RoomMembershipLockStatus value)
		{
			return null;
		}

		public static RoomMembershipLockStatus ppfRoomMembershipLockStatus_FromString(string str)
		{
			return default(RoomMembershipLockStatus);
		}

		public static IntPtr ppf_RoomOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_RoomOptions_Destroy(IntPtr handle)
		{
		}

		public static void ppf_RoomOptions_SetDataStoreString(IntPtr handle, string key, string value)
		{
		}

		public static void ppf_RoomOptions_ClearDataStore(IntPtr handle)
		{
		}

		public static void ppf_RoomOptions_SetExcludeRecentlyMet(IntPtr handle, bool value)
		{
		}

		public static void ppf_RoomOptions_SetMaxUserResults(IntPtr handle, uint value)
		{
		}

		public static void ppf_RoomOptions_SetOrdering(IntPtr handle, UserOrdering value)
		{
		}

		public static void ppf_RoomOptions_SetRecentlyMetTimeWindow(IntPtr handle, long value)
		{
		}

		public static void ppf_RoomOptions_SetRoomId(IntPtr handle, ulong value)
		{
		}

		public static void ppf_RoomOptions_SetTurnOffUpdates(IntPtr handle, bool value)
		{
		}

		public static void ppf_RoomOptions_SetName(IntPtr handle, string name)
		{
		}

		public static void ppf_RoomOptions_SetPassword(IntPtr handle, string password)
		{
		}

		public static ulong ppf_Room_CreateAndJoinPrivate2(RoomJoinPolicy joinPolicy, uint maxUsers, IntPtr roomOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Room_Get(ulong roomID)
		{
			return 0uL;
		}

		public static ulong ppf_Room_GetCurrent()
		{
			return 0uL;
		}

		public static ulong ppf_Room_GetCurrentForUser(string userID)
		{
			return 0uL;
		}

		public static ulong ppf_Room_GetInvitableUsers2(IntPtr roomOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Room_GetModeratedRooms(int page_idx, int page_size)
		{
			return 0uL;
		}

		public static ulong ppf_Room_JoinNamed(RoomJoinPolicy joinPolicy, bool createIfNotExist, uint maxUsers, IntPtr roomOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Room_GetNamedRooms(int page_idx, int page_size)
		{
			return 0uL;
		}

		public static ulong ppf_Room_InviteUser(ulong roomID, string inviteToken)
		{
			return 0uL;
		}

		public static ulong ppf_Room_Join2(ulong roomID, IntPtr roomOptions)
		{
			return 0uL;
		}

		public static ulong ppf_Room_KickUser(ulong roomID, string userID, int kickDurationSeconds)
		{
			return 0uL;
		}

		public static ulong ppf_Room_LaunchInvitableUserFlow(ulong roomID)
		{
			return 0uL;
		}

		public static ulong ppf_Room_Leave(ulong roomID)
		{
			return 0uL;
		}

		public static ulong ppf_Room_SetDescription(ulong roomID, string description)
		{
			return 0uL;
		}

		public static ulong ppf_Room_UpdateDataStore(ulong roomID, IntPtr data, uint numItems)
		{
			return 0uL;
		}

		public static ulong ppf_Room_UpdateMembershipLockStatus(ulong roomID, RoomMembershipLockStatus membershipLockStatus)
		{
			return 0uL;
		}

		public static ulong ppf_Room_UpdateOwner(ulong roomID, string userID)
		{
			return 0uL;
		}

		public static ulong ppf_Room_UpdatePrivateRoomJoinPolicy(ulong roomID, RoomJoinPolicy newJoinPolicy)
		{
			return 0uL;
		}

		public static void ppf_RtcGetTokenOptions_Destroy(IntPtr obj)
		{
		}

		public static IntPtr ppf_RtcGetTokenOptions_Create()
		{
			return (IntPtr)0;
		}

		public static void ppf_RtcGetTokenOptions_SetUserId(IntPtr obj, string value)
		{
		}

		public static void ppf_RtcGetTokenOptions_SetRoomId(IntPtr obj, string value)
		{
		}

		public static void ppf_RtcGetTokenOptions_SetTtl(IntPtr obj, int value)
		{
		}

		public static void ppf_RtcGetTokenOptions_ClearPrivileges(IntPtr obj)
		{
		}

		public static void ppf_RtcGetTokenOptions_SetPrivileges(IntPtr obj, RtcPrivilege k, int v)
		{
		}

		public static ulong ppf_Rtc_GetToken(IntPtr options)
		{
			return 0uL;
		}

		public static ulong ppf_Sport_GetDailySummary(long beginTime, long endTime)
		{
			return 0uL;
		}

		public static ulong ppf_Sport_GetSummary(long beginTime, long endTime)
		{
			return 0uL;
		}

		public static ulong ppf_Sport_GetUserInfo()
		{
			return 0uL;
		}

		public static ulong ppf_User_Get(string userID)
		{
			return 0uL;
		}

		public static ulong ppf_User_GetAccessToken()
		{
			return 0uL;
		}

		public static ulong ppf_User_GetIdToken()
		{
			return 0uL;
		}

		public static ulong ppf_User_GetLoggedInUser()
		{
			return 0uL;
		}

		public static ulong ppf_User_GetLoggedInUserFriends()
		{
			return 0uL;
		}

		public static ulong ppf_User_GetNextUserArrayPage(string param)
		{
			return 0uL;
		}

		public static ulong ppf_User_LaunchFriendRequestFlow(string userID)
		{
			return 0uL;
		}

		public static ulong ppf_User_GetLoggedInUserFriendsAndRooms()
		{
			return 0uL;
		}

		public static ulong ppf_User_GetNextUserAndRoomArrayPage(string param)
		{
			return 0uL;
		}

		public static ulong ppf_User_GetAuthorizedPermissions()
		{
			return 0uL;
		}

		public static ulong ppf_User_RequestUserPermissions(IntPtr[] permissions, int size)
		{
			return 0uL;
		}

		public static ulong ppf_User_GetRelations(IntPtr[] userIds, int size)
		{
			return 0uL;
		}

		public static ulong ppf_User_EntitlementCheck(bool killApp)
		{
			return 0uL;
		}

		public static ulong ppf_User_GetOrgScopedID(string userID)
		{
			return 0uL;
		}

		public static RtcAudioSampleRate ppf_RtcAudioFrame_GetSampleRate(IntPtr obj)
		{
			return default(RtcAudioSampleRate);
		}

		public static RtcAudioChannel ppf_RtcAudioFrame_GetChannel(IntPtr obj)
		{
			return default(RtcAudioChannel);
		}

		public static long ppf_RtcAudioFrame_GetTimeStampInUs(IntPtr obj)
		{
			return 0L;
		}

		public static IntPtr ppf_RtcAudioFrame_GetData(IntPtr obj)
		{
			return (IntPtr)0;
		}

		public static long ppf_RtcAudioFrame_GetDataSize(IntPtr obj)
		{
			return 0L;
		}

		public static ulong ppf_Achievements_GetProgressByName(string[] names)
		{
			return 0uL;
		}

		public static ulong ppf_Achievements_GetDefinitionsByName(string[] names)
		{
			return 0uL;
		}

		public static ulong ppf_IAP_GetProductsBySKU(string[] names)
		{
			return 0uL;
		}

		public static ulong ppf_Leaderboard_GetEntriesByIds(string leaderboardName, int pageSize, int pageIdx, LeaderboardStartAt startAt, string[] userIDs)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_GetEntriesByIds(ulong challengeID, LeaderboardStartAt startAt, string[] userIDs, int pageIdx, int pageSize)
		{
			return 0uL;
		}

		public static ulong ppf_Challenges_Invites(ulong challengeID, string[] userIDs)
		{
			return 0uL;
		}

		public static ulong ppf_User_RequestUserPermissions(string[] permissions)
		{
			return 0uL;
		}

		public static ulong ppf_User_GetRelations(string[] userIds)
		{
			return 0uL;
		}

		public static ulong ppf_Presence_SendInvites(string[] userIDs)
		{
			return 0uL;
		}

		public static Dictionary<string, string> DataStoreFromNative(IntPtr ppfDataStore)
		{
			return null;
		}

		[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
		public static extern void ppf_Rtc_RegisterLocalAudioProcessor(RtcProcessAudioFrameFunction rtcProcessAudioFrameFunction, RtcAudioChannel channel, RtcAudioSampleRate sampleRate);

		[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
		public static extern PlatformInitializeResult ppf_InitializeAndroid(string appId, IntPtr activityObj, IntPtr env);

		[DllImport("pxrplatformloader", CallingConvention = CallingConvention.Cdecl)]
		public static extern ulong ppf_InitializeAndroidAsynchronous(string appId, IntPtr activityObj, IntPtr env);
	}
}
