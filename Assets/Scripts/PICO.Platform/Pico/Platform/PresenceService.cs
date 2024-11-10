using System;
using System.Collections.Generic;
using Pico.Platform.Models;

namespace Pico.Platform
{
	public static class PresenceService
	{
		public static Task<UserList> GetInvitableUsers(InviteOptions options)
		{
			return null;
		}

		public static Task<ApplicationInviteList> GetSentInvites()
		{
			return null;
		}

		public static Task<ApplicationInviteList> GetNextApplicationInviteListPage(ApplicationInviteList list)
		{
			return null;
		}

		public static Task<SendInvitesResult> SendInvites(string[] userIds)
		{
			return null;
		}

		public static Task Set(PresenceOptions options)
		{
			return null;
		}

		[Obsolete("SetDestination can be replaced by Set()", false)]
		public static Task SetDestination(string apiName)
		{
			return null;
		}

		[Obsolete("SetIsJoinable can be replaced by Set()", false)]
		public static Task SetIsJoinable(bool joinable)
		{
			return null;
		}

		[Obsolete("SetLobbySession can be replaced by Set()", false)]
		public static Task SetLobbySession(string lobbySessionId)
		{
			return null;
		}

		[Obsolete("SetMatchSession can be replaced by Set()", false)]
		public static Task SetMatchSession(string matchSessionId)
		{
			return null;
		}

		[Obsolete("SetExtra can be replaced by Set()", false)]
		public static Task SetExtra(string extra)
		{
			return null;
		}

		public static Task Clear()
		{
			return null;
		}

		public static Task<DestinationList> GetDestinations()
		{
			return null;
		}

		public static Task<DestinationList> GetNextDestinationListPage(DestinationList destinationList)
		{
			return null;
		}

		public static Task LaunchInvitePanel()
		{
			return null;
		}

		public static Task ShareVideoByImages(List<string> imagePaths)
		{
			return null;
		}

		public static Task ShareVideo(string videoPath, string videoThumbPath)
		{
			return null;
		}

		public static void SetJoinIntentReceivedNotificationCallback(Message<PresenceJoinIntent>.Handler callback)
		{
		}
	}
}
